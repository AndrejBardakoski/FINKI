import cv2
import numpy as np

img_org = cv2.imread("car.jpg")
img_gray = cv2.cvtColor(img_org, cv2.COLOR_BGR2GRAY)
img_gausian = cv2.GaussianBlur(img_gray, (5, 5), 0)

img_canny = cv2.Canny(img_gray, 50, 70)

kernel = np.ones((3, 3), np.uint8)
img_dilation = cv2.dilate(img_gausian, kernel, iterations=1)
img_diff = cv2.absdiff(img_gausian, img_dilation)
ret, img_diff_th = cv2.threshold(img_diff, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)

kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (3, 3))
img_edge_close = cv2.morphologyEx(img_diff_th, cv2.MORPH_CLOSE, kernel)
# img_open= cv2.morphologyEx(img_close, cv2.MORPH_OPEN, kernel)


ret, img_th = cv2.threshold(img_gray, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)
kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (3, 3))
img_close = cv2.morphologyEx(img_th, cv2.MORPH_CLOSE, kernel)
img_open = cv2.morphologyEx(img_close, cv2.MORPH_OPEN, kernel)
img_close = cv2.morphologyEx(img_open, cv2.MORPH_CLOSE, kernel)

contours, hierarchy = cv2.findContours(img_close, cv2.RETR_LIST, cv2.CHAIN_APPROX_SIMPLE)
# img_contours = cv2.drawContours(img_org, contours, -1, (0, 255, 0), 3)

# min
# max

approx = []
for cnt in contours:
    area = cv2.contourArea(cnt)
    if 20000 < area < 50000:
        epsilon = 0.01 * cv2.arcLength(cnt, True)
        cnt = cv2.approxPolyDP(cnt, epsilon, True)
        approx.append(cnt)
        print(approx)

        # rect = cv2.minAreaRect(cnt)
        # box = cv2.boxPoints(rect)
        # box = np.int0(box)
        # print(box)

img_contours = cv2.drawContours(img_org, approx, -1, (0, 255, 0), 3)

top_left = approx[0][0][0]
bottom_left = approx[0][1][0]
bottom_right = approx[0][2][0]
top_right = approx[0][3][0]

print (bottom_right[0])

# not implemented
plate=img_org[top_left[1]:bottom_right[1],top_left[0]:bottom_right[0]]
# plate=img_org[398:452,321:677]


# cv2.imshow("gray",img_gray)
# cv2.imshow("gausian",img_gausian)
# cv2.imshow("canny",img_canny)
# cv2.imshow("img_diff",img_diff_th)
# cv2.imshow("close",img_close)
# cv2.imshow("img_th",img_th)
cv2.imshow("contours", img_contours)
cv2.imwrite("car_plate.jpg", img_contours)
cv2.imshow("plate",plate)
# cv2.imwrite("plate.jpg",plate)


cv2.waitKey(0)
cv2.destroyAllWindows()
