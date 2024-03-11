import argparse

import cv2
import numpy as np
import glob
from matplotlib import pyplot as plt

# python zad4.py --imagePath query/11628.jpg

# construct the argument parser and parse the arguments
ap = argparse.ArgumentParser()
ap.add_argument("-d", "--imagePath", default="query/14729.jpg",
                help="Path to the query image")
args = vars(ap.parse_args())


def get_contour(img):
    contours, hierarchy = cv2.findContours(img, 1, 2)

    # Extract the relevant contour based on area ratio.
    # We use the # area ratio because the main image boundary contour is # extracted as well and we don't want that.
    # This area ratio # threshold will ensure that we only take the contour inside # the image.
    for contour in contours:
        area = cv2.contourArea(contour)
        img_area = img.shape[0] * img.shape[1]
        if 0.05 < area / float(img_area) < 0.8:
            return contour


def segmentation(img):
    blur = cv2.GaussianBlur(img, (5, 5), 0)
    ret3, th = cv2.threshold(blur, 0, 255, cv2.THRESH_BINARY_INV + cv2.THRESH_OTSU)

    se = cv2.getStructuringElement(cv2.MORPH_RECT, (2, 4))
    se2 = cv2.getStructuringElement(cv2.MORPH_RECT, (6, 6))

    closing = cv2.morphologyEx(th, cv2.MORPH_CLOSE, se2)
    opening = cv2.morphologyEx(closing, cv2.MORPH_OPEN, se)

    return opening


index = {}
result = {}
for imagePath in glob.glob("database/" + "/*.jpg"):
    img = cv2.imread(imagePath, 0)

    segmentedImg = segmentation(img)

    contour = get_contour(segmentedImg)

    index[imagePath] = contour

# query_img = cv2.imread("query/1202.jpg", 1)
# query_img = cv2.imread("query/12034.jpg", 1)
# query_img = cv2.imread("query/12181.jpg", 1)
# query_img = cv2.imread("query/14729.jpg", 1)
query_img = cv2.imread(args["imagePath"], 1)
query_img_gray = cv2.cvtColor(query_img, cv2.COLOR_BGR2GRAY)
query_segmented = segmentation(query_img_gray)
query_contour = get_contour(query_segmented)

for (imgPath, cnt) in index.items():
    # ret = cv2.matchShapes(query_contour, cnt, 1, 0.0)
    # ret = cv2.matchShapes(query_contour, cnt, 2, 0.0)
    ret = cv2.matchShapes(query_contour, cnt, 3, 0.0)
    result[imgPath] = ret
# result = sorted([(v, k) for (k, v) in result.items()])
result = sorted(result.items(), key=lambda x: x[1])
for i in result:
    print(i[0], i[1])

bestMatch = cv2.imread(result[0][0])
cv2.imshow("bestMatch", bestMatch)
cv2.imshow("Querry image", query_img)
cv2.waitKey(0)
cv2.destroyAllWindows()

