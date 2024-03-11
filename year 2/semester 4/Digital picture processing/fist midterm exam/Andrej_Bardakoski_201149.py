import cv2
import numpy as np
from matplotlib import pyplot as plt

img_org = cv2.imread("flowers.jpg", 1)
img_gray = cv2.cvtColor(img_org, cv2.COLOR_BGR2GRAY)
img_rgb = cv2.cvtColor(img_org, cv2.COLOR_BGR2RGB)

mask = np.zeros(img_gray.shape)
mask=np.uint8(mask)
mask[130:620,180:730]=255

img_masked=cv2.bitwise_and(img_gray,img_gray,mask=mask)

hist_mask = cv2.calcHist([img_gray],[0],mask,[256],[0,256])

grad_x = cv2.Sobel(img_gray, cv2.CV_16S, 1, 0, ksize=3, scale=1, delta=0, borderType=cv2.BORDER_DEFAULT)
grad_y = cv2.Sobel(img_gray, cv2.CV_16S, 0, 1, ksize=3, scale=1, delta=0, borderType=cv2.BORDER_DEFAULT)

img_grad_x = cv2.convertScaleAbs(grad_x)
img_grad_y = cv2.convertScaleAbs(grad_y)

plt.subplot(321),plt.imshow(img_rgb,'gray'),plt.title('ORIGINAL')
plt.subplot(322),plt.imshow(img_gray,'gray'),plt.title('GRAY')
plt.subplot(323),plt.imshow(img_masked,'gray'),plt.title('MASKED')
plt.subplot(324),plt.plot(hist_mask),plt.title('REFLECT_101')
plt.subplot(325),plt.imshow(img_grad_y,'gray'),plt.title('SOBEL_Y')
plt.subplot(326),plt.imshow(img_grad_x,'gray'),plt.title('SOBEL_X')

plt.show()

