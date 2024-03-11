import cv2
import numpy as np
from matplotlib import pyplot as plt

img_8bit = cv2.imread('image1.jpg', 0)
Z = img_8bit.flatten()
Z = np.float32(Z)
criteria = (cv2.TERM_CRITERIA_EPS + cv2.TERM_CRITERIA_MAX_ITER, 10, 1.0)

result = [img_8bit,0, 0, 0, 0, 0]

for i in range(1,6):
    K = 2 ** (i)
    compactness, label, center = cv2.kmeans(Z, K, None, criteria, 10, cv2.KMEANS_RANDOM_CENTERS)
    center = np.uint8(center)
    result[i] = center[label.flatten()].reshape(img_8bit.shape)
cv2.waitKey(0)

titles = ['Original (8bit)', '(1bit)', '(2bit)', '(3bit)', '(4bit)', '(5bit)']
for i in range(6):
    plt.subplot(2, 3, i + 1), plt.imshow(result[i], 'gray')
    plt.title(titles[i])
    plt.xticks([]), plt.yticks([])
plt.show()