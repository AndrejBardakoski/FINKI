import cv2
import numpy as np
import glob

FLANN_INDEX_KDTREE = 1
index_params = dict(algorithm=FLANN_INDEX_KDTREE, trees=5)
search_params = dict(checks=50)
sift = cv2.SIFT_create()

img_org = cv2.imread("hw7_poster_3.jpg")

height = 600
width = int(height * img_org.shape[1] / img_org.shape[0])
dim = (width, height)
img_org = cv2.resize(img_org, dim, interpolation=cv2.INTER_AREA)

img = cv2.cvtColor(img_org, cv2.COLOR_BGR2GRAY)

(kps1, descs1) = sift.detectAndCompute(img, None)

goodBest = []
for imagePath in glob.glob("Database/" + "/*.jpg"):
    imgDataOrg = cv2.imread(imagePath)
    height = 400
    width = int(height * imgDataOrg.shape[1] / imgDataOrg.shape[0])
    dim = (width, height)
    imgDataOrg = cv2.resize(imgDataOrg, dim, interpolation=cv2.INTER_AREA)
    imgData = cv2.cvtColor(imgDataOrg, cv2.COLOR_BGR2GRAY)
    (kps2, descs2) = sift.detectAndCompute(imgData, None)

    flann = cv2.FlannBasedMatcher(index_params, search_params)

    matches = flann.knnMatch(descs1, descs2, k=2)
    good = []
    for m, n in matches:
        if m.distance < 0.8 * n.distance:
            good.append([m])
        if len(good) > len(goodBest):
            goodBest = good
            imgDataBest = imgDataOrg
            imgDataGray = imgData
            kpsBest = kps2
            descsBest = descs2

src_pts = np.float32([kps1[m[0].queryIdx].pt for m in goodBest]).reshape(-1, 1, 2)
dst_pts = np.float32([kpsBest[m[0].trainIdx].pt for m in goodBest]).reshape(-1, 1, 2)

M, mask = cv2.findHomography(src_pts, dst_pts, cv2.RANSAC, 5.0)
matchesMask = mask
draw_params = dict(matchColor=(0, 255, 0),  # draw matches in green color
                   singlePointColor=None,
                   matchesMask=matchesMask,  # draw only inliers
                   flags=2)
img3 = cv2.drawMatchesKnn(img_org, kps1, imgDataBest, kpsBest, goodBest, None, flags=2)
img4 = cv2.drawMatchesKnn(img_org, kps1, imgDataBest, kpsBest, goodBest, None, **draw_params)
img2 = img_org
imgDataBest2 = imgDataBest
img2 = cv2.drawKeypoints(img, kps1, img2, flags=cv2.DRAW_MATCHES_FLAGS_DRAW_RICH_KEYPOINTS)
imgDataBest2 = cv2.drawKeypoints(imgDataBest, kpsBest, imgDataBest2, flags=cv2.DRAW_MATCHES_FLAGS_DRAW_RICH_KEYPOINTS)

cv2.imshow("Img", img2)
cv2.imshow("ImgData", imgDataBest2)

cv2.imshow("3", img3)

cv2.imshow("4", img4)

cv2.waitKey(0)
