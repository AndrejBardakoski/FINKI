import cv2
from matplotlib import pyplot as plt

img_8bit = cv2.imread('image1.jpg', 0)
img_5bit = img_8bit >> 3 << 3
img_4bit = img_8bit >> 4 << 4
img_3bit = img_8bit >> 5 << 5
img_2bit = img_8bit >> 6 << 6
img_1bit = img_8bit >> 7 << 7

plt.figure(1)
plt.subplot(231), plt.imshow(img_8bit, 'gray'), plt.title('original')
plt.subplot(232), plt.imshow(img_5bit, 'gray'), plt.title('img 5 bit')
plt.subplot(233), plt.imshow(img_4bit, 'gray'), plt.title('img 4 bit')
plt.subplot(234), plt.imshow(img_3bit, 'gray'), plt.title('img 3 bit')
plt.subplot(235), plt.imshow(img_2bit, 'gray'), plt.title('img 2 bit')
plt.subplot(236), plt.imshow(img_1bit, 'gray'), plt.title('img 1 bit')
plt.show()


