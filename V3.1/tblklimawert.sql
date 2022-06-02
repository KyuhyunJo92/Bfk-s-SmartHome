/*SELECT * FROM dbtemp.tblklimawert;
INSERT INTO dbtemp.tblklimawert(temp, druck, zeitpunkt, fksensid) VALUES(1,1,'1',1);*/
CREATE TABLE IF NOT EXISTS dbtemp.tblsensor(sensid INT PRIMARY KEY NOT NULL, sens_ip VARCHAR(30) NOT NULL UNIQUE KEY, sens_ort VARCHAR(30));
INSERT INTO dbtemp.tblsensor(sensid, sens_ip, sens_ort) VALUES(1,'192.168.1.145','wohnzimmer');
INSERT INTO dbtemp.tblsensor(sensid, sens_ip, sens_ort) VALUES(2,'112.168.1.143','schlafzimmer');
INSERT INTO dbtemp.tblsensor(sensid, sens_ip, sens_ort) VALUES(3,'127.1.1.154','kuechen');
CREATE TABLE IF NOT EXISTS dbtemp.tblklimawert(kwid INT PRIMARY KEY NOT NULL AUTO_INCREMENT, temp DOUBLE, lfeuchte DOUBLE, druck DOUBLE, ppmco2 DOUBLE, zeitpunkt DATETIME, fksensid INT, FOREIGN KEY(fksensid) REFERENCES dbtemp.tblsensor(sensid) );