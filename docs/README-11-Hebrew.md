# Rock, Paper, Scissors
אלופי האפלים מתחילים לכוון את מחנה הם על חוף. כדי לחשב מי הארוחה הקרובה ביותר למחסן המנות, התחרות של Rock, Paper, Scissors באמצע בלבד.

Rock, Paper, Scissors הוא משחק בין שני שחקנים. כל משחק מכיל הרבה מסיבות; בכל מסיבה, השחקנים בוחרים באופן בו-זמני אחד מרוק, נייר או חרביים עם טווח יד. לאחר מכן, מנצח עבור המסיבה נבחר: רוק מנצח נגד חרביים, נייר מנצח נגד רוק, חרביים מנצחים נגד נייר. אם שני השחקנים בוחרים את אותו צורה, המסיבה מסתיימת בחוגוג במקומו.

צורות ותוצאות
יש 3 צורות. הן:

Rock (קוד היריב: A, קוד השחקן: X, מנצח נגד: C, ניקוד: 1),
Paper (קוד היריב: B, קוד השחקן: Y, מנצח נגד: A, ניקוד: 2),
Scissors (קוד היריב: C, קוד השחקן: Z, מנצח נגד: B, ניקוד: 3),

ניקודי התוצאות הם:
-ניצחון: 6
-הפסד: 0
-תיקו: 3

## הכללים
מוכן לעזור לך אתמול, אחד מהאלו

## הכללים
בעקבות העזרה שלכם אתמול, אחד מהאלפים מסיר לכם מדריך אסתר לאסטרטגיות (הקוד המנוע שלכם) שאמרים לכם שהוא יוכל לעזור לכם לנצח. "העמודה הראשונה היא מה שלוחוב שלך ישתבח:

A עבור Rock,
B עבור Paper,
C עבור Scissors,
 ... והעמודה השנייה היא מה שאתם צריכים לשחק בתשובה:
X עבור Rock,
Y עבור Paper,
Z עבור Scissors,
לנצח בכל פעם הייתה חשודה, כך שהתשובות חייבות לכלול בחינוך העזה.

המנצח של כל הטורניר הוא השחקן עם הניקוד הגבוה ביותר. הניקוד הכולל שלכם הוא סכום של הניקודים שלכם עבור כל החזרה. הניקוד עבור החזרה הבלתי יחודית הוא הניקוד עבור הצורה שבחרתם
(Rock = 1,Paper = 2,Scissors = 3,) לחשוב את הניקוד עבור התוצאה של החזרה (נצחון = 6,הפסד = 0,תיקו = 3).

מאחר שאינך בטוח אם האלף מנסה לעזור לך או למזויף אותך, עליך לחשב את הניקוד שתקבל אם תפעיל את המדריך לאסורים.

דוגמא למשחק
מאחר שאינך בטוח אם האלף מנסה לעזור לך או למזויף אותך, עליך לחשב את הניקוד שתקבל אם תפעיל את המדריך לאסורים.

למשל, נא לקחת בחשבון את המדריך הבא:

A Y
B X
C Z
המדריך הזה מניח וממליץ על הבא:

האויב בחר ב- (קוד A), השחקן בחר ב- (קוד Y) הסיבוב היה win, עם ניקוד של 8 ניקוד בחירה: 2, ניקוד תוצאה: 6
האויב בחר ב- (קוד B), השחקן בחר ב- (קוד X) הסיבוב היה loss, עם ניקוד של 1 ניקוד בחירה: 1, ניקוד תוצאה: 0
האויב בחר ב- (קוד C), השחקן בחר ב- (קוד Z) הסיבוב היה draw, עם ניקוד של 6 ניקוד בחירה: 3, ניקוד תוצאה: 3

הניקוד הסופי הוא: 15