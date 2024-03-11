import cv2
import numpy as np
import glob
from matplotlib import pyplot as plt

result = []
for imagePath in glob.glob("database/" + "/*.jpg"):
    img = cv2.imread(imagePath, 0)

    # Otsu's thresholding after Gaussian filtering
    blur = cv2.GaussianBlur(img, (5, 5), 0)
    ret3, th = cv2.threshold(blur, 0, 255, cv2.THRESH_BINARY_INV + cv2.THRESH_OTSU)

    se = cv2.getStructuringElement(cv2.MORPH_RECT, (2, 4))
    # se = cv2.getStructuringElement(cv2.MORPH_RECT, (5, 1))
    se2 = cv2.getStructuringElement(cv2.MORPH_RECT, (6, 6))
    # se2 = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (6, 6))

    # opening = cv2.morphologyEx(th, cv2.MORPH_OPEN, se)
    closing = cv2.morphologyEx(th, cv2.MORPH_CLOSE, se2)
    # closing = cv2.morphologyEx(opening, cv2.MORPH_CLOSE, se)
    opening = cv2.morphologyEx(closing, cv2.MORPH_OPEN, se)

    # result.append(th)
    # result.append(closing)
    result.append(opening)

    # Користење само на отсу трешхолд дава добри резултати за повеќето слики но за некои слики созадава дупки,
    # а за некои создава и шум во позадината
    # Дупките ќе пробаме да ги затвориме со примена на морфолошката функција closing, со ова успеваме успешно
    # да ги затвориме дупките но во некои слики доаѓа до спојување на разделени елементи од листот
    # а при користење на поголем StructuringElement доаѓа и до нарушување (измазнување) на работ на листот
    #  со примена на функцијата opening успешно се отсранува позадинскиот шум но во ноекои слики се случува отсранување
    #  на дел од дршката на листот
    #  со примена на затварање а потоа на отварање се успева да се решат проблемите на дупки и позадински шум
    #  и притоа да се намалат страничните ефекти (но  сепак во некои слики сеуште се присутни)
    #  /

    # cv2.imshow("original", img)
    # cv2.imshow("threshold", th)
    # cv2.imshow("opening", opening)
    # cv2.imshow("closed", closing)
    # cv2.waitKey(0)

i = 0
for imgResult in result:
    i += 1
    if i <= 30:
        plt.subplot(5, 6, i)
        plt.imshow(imgResult, 'gray')
        plt.xticks([]), plt.yticks([])
plt.show()
