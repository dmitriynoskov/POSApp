SELECT RS.RashodID, R.StaffID, P.FullName, RS.Quantity, RS.Price, P.Price 
FROM RASHODSUB as RS
LEFT JOIN RASHOD as R ON RS.RashodID = R.ID
LEFT JOIN PRODUCT as P ON RS.ProductID = P.Id
WHERE RS.RashodID = 6

DELETE FROM RASHODSUB
WHERE RashodID = 6 AND ProductID IN (SELECT P.Id
FROM RASHODSUB as RS
LEFT JOIN PRODUCT as P ON RS.ProductID = P.Id
WHERE P.FullName = 'Skirt;131141;Green;XS')

Select * FROM PERSON WHERE Barcode='C101' AND Staff='False'

UPDATE RASHODSUB 
SET Quantity=2, TotalAmount=Quantity*Price 
WHERE RashodID=5 AND ProductID IN (SELECT P.ID
FROM PRODUCT AS P
WHERE Barcode='102435655462')

SELECT RS.RashodID, P.Barcode, P.FullName, Rs.Quantity, RS.Price, R.RashodDate, R.RashodTime, PS.Name as Staff, PS2.Name as Client
From RASHODSUB AS RS
Join PRODUCT AS P ON RS.ProductID = P.Id
Join RASHOD As R ON RS.RashodID = R.Id
Join PERSON AS PS ON R.StaffID = PS.Id
LEFT JOIN PERSON as PS2 ON R.ClientID = PS2.Id 
Order by RS.RashodID, Rs.ProductID

SELECT RS.*, P.Name as Staff, P2.Name as Client
FROM RASHODSUB as RS
LEFT JOIN PERSON as P ON R.ClientID = p.Id
INNER JOin PERSON as P2 On R.StaffID = P2.Id
INNER JOIN RASHOD as R ON RS.RashodID = R.Rashod

SELECT P.Name
FROM Rashod as R
LEFT JOIN PERSON as P ON R.ClientID = P.ID

SELECT P.ID,P.FullName, G.GroupName as TIP , G2.GroupName as Gruppa, g3.GroupName as SubGroup
FROM PRODUCT as P
LEFT JOIN GROUPS as G ON P.TypeID=G.ID
LEFT JOIN GROUPS as G2 ON p.GroupID=G2.ID
LEFT JOIN GROUPS as G3 ON p.SubGroupID=g3.ID

SELECT SUM(R.TotalAmount) as Total, (SELECT Sum(TotalAmount) FROM RASHOD WHERE Done='True' AND RashodDate='28.10.2017' AND Nal='True') as NAL, 
(SELECT Sum(TotalAmount) FROM RASHOD WHERE Done='True' AND RashodDate='28.10.2017' AND Nal='FALSE') AS VISA
From RASHOD as R
WHERE r.RashodDate='28.10.2017' AND Done='True' 

SELECT P.ID, P.FullName, G.Akciya, G.AkciyaValue
From PRODUCT as P
JOIN GROUPS as G ON P.SubGroupID = G.Id
WHERE P.ID = 2

SELECT R.Id, R.RashodDate, R.RashodTime, P.FullName, RS.Quantity, RS.Price, PS.Name, PS2.Name
FROM RASHOD as R
INNER JOIN RASHODSUB as RS ON R.Id = RS.RashodID
INNER JOIN PRODUCT as P ON RS.ProductID = P.Id
INNER JOIN PERSON as PS ON R.StaffID = PS.Id
LEFT JOIN PERSON as PS2 ON R.ClientID = PS2.Id
WHERE RashodDate = '01.10.2017'

SELECT P.FullName, S.Quantity
FROM PRODUCT as P
INNER JOIN STOCK as S ON P.Id = S.ProductID
WHERE P.Code='261518'

SELECT R.ID, P.FullName, RS.Price, RS.Quantity, RS.TotalAmount, R.Nal, R.TotalAmount, R.VISA, PS.Name
FROM RASHOD as R
INNER JOIN RASHODSUB as RS ON R.Id=RS.RashodID
INNER JOIN PRODUCT as P ON RS.ProductID=P.Id
LEFT JOIN PERSON as PS ON R.ClientID=PS.ID
WHERE R.Id='20'

SELECT PS.Name, SUM(R.TotalItems), SUM(R.TotalAmount)
FROM RASHOD as R
JOIN PERSON as PS ON R.StaffID=PS.Id
WHERE R.RashodDate='28.10.2017' AND R.Done='True'
GROUP BY PS.Name
