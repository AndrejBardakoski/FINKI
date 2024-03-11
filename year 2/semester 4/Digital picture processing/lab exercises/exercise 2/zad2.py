import cv2
import numpy as np
from matplotlib import pyplot as plt

# img = cv2.imread('berndsface.png')
img = cv2.imread('bike.png')
# img = cv2.imread('messi5.jpg',0)

img = cv2.GaussianBlur(img, (5, 5), 0)

filter1 = np.array(([1, 1, 0], [1, 0, -1], [0, -1, -1]), dtype="float32")
filteredImg1 = cv2.filter2D(img, -1, filter1)
filteredImg1 = abs(filteredImg1)
filteredImg1 = filteredImg1 / np.amax(filteredImg1[:])

filter2 = np.array(([1, 1, 1], [0, 0, 0], [-1, -1, -1]), dtype="float32")
filteredImg2 = cv2.filter2D(img, -1, filter2)
filteredImg2 = abs(filteredImg2)
filteredImg2 = filteredImg2 / np.amax(filteredImg2[:])

filter3 = np.array(([0, 1, 1], [-1, 0, 1], [-1, -1, 0]), dtype="float32")
filteredImg3 = cv2.filter2D(img, -1, filter3)
filteredImg3 = abs(filteredImg3)
filteredImg3 = filteredImg3 / np.amax(filteredImg3[:])

filter4 = np.array(([1, 0, -1], [1, 0, -1], [1, 0, -1]), dtype="float32")
filteredImg4 = cv2.filter2D(img, -1, filter4)
filteredImg4 = abs(filteredImg4)
filteredImg4 = filteredImg4 / np.amax(filteredImg4[:])

filter5 = np.array(([-1, 0, 1], [-1, 0, 1], [-1, 0, 1]), dtype="float32")
filteredImg5 = cv2.filter2D(img, -1, filter5)
filteredImg5 = abs(filteredImg5)
filteredImg5 = filteredImg5 / np.amax(filteredImg5[:])

filter6 = np.array(([0, -1, -1], [1, 0, -1], [1, 1, 0]), dtype="float32")
filteredImg6 = cv2.filter2D(img, -1, filter6)
filteredImg6 = abs(filteredImg6)
filteredImg6 = filteredImg6 / np.amax(filteredImg6[:])

filter7 = np.array(([-1, -1, -1], [0, 0, 0], [1, 1, 1]), dtype="float32")
filteredImg7 = cv2.filter2D(img, -1, filter7)
filteredImg7 = abs(filteredImg7)
filteredImg7 = filteredImg7 / np.amax(filteredImg7[:])

filter8 = np.array(([-1, -1, 0], [-1, 0, 1], [0, 1, 1]), dtype="float32")
filteredImg8 = cv2.filter2D(img, -1, filter8)
filteredImg8 = abs(filteredImg8)
filteredImg8 = filteredImg8 / np.amax(filteredImg8[:])

tmpMax = np.maximum(filteredImg1, filteredImg2)
tmpMax = np.maximum(tmpMax, filteredImg3)
tmpMax = np.maximum(tmpMax, filteredImg4)
tmpMax = np.maximum(tmpMax, filteredImg5)
tmpMax = np.maximum(tmpMax, filteredImg6)
tmpMax = np.maximum(tmpMax, filteredImg7)
tmpMax = np.maximum(tmpMax, filteredImg8)

# imgResult = tmpMax  # no threshold
# ret, imgResult = cv2.threshold(tmpMax, 0.10, 1, cv2.THRESH_TOZERO)
ret, imgResult = cv2.threshold(tmpMax, 0.15, 1, cv2.THRESH_TOZERO)
# ret, imgResult = cv2.threshold(tmpMax, 0.20, 1, cv2.THRESH_TOZERO)
# ret, imgResult = cv2.threshold(tmpMax, 0.10, 1, cv2.THRESH_BINARY)
# ret, imgResult = cv2.threshold(tmpMax, 0.15, 1, cv2.THRESH_BINARY)
# ret, imgResult = cv2.threshold(tmpMax, 0.20, 1, cv2.THRESH_BINARY)
# ret, imgResult = cv2.threshold(tmpMax, 0.30, 1, cv2.THRESH_BINARY)


plt.figure(1)
plt.subplot(331), plt.imshow(filteredImg1, 'gray'), plt.title('Compas NW')
plt.subplot(332), plt.imshow(filteredImg2, 'gray'), plt.title('Compas N')
plt.subplot(333), plt.imshow(filteredImg3, 'gray'), plt.title('Compas  NE')
plt.subplot(334), plt.imshow(filteredImg4, 'gray'), plt.title('Compas W')
plt.subplot(335), plt.imshow(img, 'gray'), plt.title('original')
plt.subplot(336), plt.imshow(filteredImg5, 'gray'), plt.title('Compas E')
plt.subplot(337), plt.imshow(filteredImg6, 'gray'), plt.title('Compas SW')
plt.subplot(338), plt.imshow(filteredImg7, 'gray'), plt.title('Compas S')
plt.subplot(339), plt.imshow(filteredImg8, 'gray'), plt.title('Compas SE')
plt.show()

cv2.imshow("Result", imgResult)
cv2.waitKey()
