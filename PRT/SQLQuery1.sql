CREATE TABLE HocSinh2(
	mahs  VARCHAR (255) PRIMARY KEY,
	hoten VARCHAR (255) NOT NULL,
	quequan VARCHAR (255) NOT NULL,
	ngaysinh DATE,
	cmnd VARCHAR (255)	UNIQUE NOT NULL,
	sdt VARCHAR (255)	UNIQUE NOT NULL,
	email VARCHAR (255) UNIQUE NOT NULL
);

INSERT INTO HocSinh2(mahs,hoten,quequan,ngaysinh,cmnd,sdt,email)
VALUES ('211105561','Pham Thi Phuong Nghi1','Ben Tre1','01/09/2004','0833030080611','08140966562','thiphuongnghipham2@gmail.com');

INSERT INTO HocSinh2(mahs,hoten,quequan,ngaysinh,cmnd,sdt,email)
VALUES ('211105562','Pham Thi Phuong Nghi3','Ben Tre4','01/09/2005','0833030080612','081409665362','thiphuongnghi3pham2@gmail.com');

INSERT INTO HocSinh2(mahs,hoten,quequan,ngaysinh,cmnd,sdt,email)
VALUES ('211105561','Pham Thi Phuong Nghi1','Ben Tre1','01/09/2004','0833030080611','08140966562','thiphuongnghipham2@gmail.com');

INSERT INTO HocSinh2(mahs,hoten,quequan,ngaysinh,cmnd,sdt,email)
VALUES ('211105561','Pham Thi Phuong Nghi1','Ben Tre1','01/09/2004','0833030080611','08140966562','thiphuongnghipham2@gmail.com');


SELECT * FROM HocSinh2
DELETE FROM HocSinh2

CREATE TABLE GiaoVien(
	magv  VARCHAR (255) PRIMARY KEY,
	hoten VARCHAR (255) NOT NULL,
	quequan VARCHAR (255) NOT NULL,
	ngaysinh DATE,
	sdt VARCHAR (255)	UNIQUE NOT NULL,
	email VARCHAR (255) UNIQUE NOT NULL
);
DELETE FROM GiaoVien

CREATE TABLE HocSinh(
	mahs  VARCHAR (255) PRIMARY KEY,
	hoten VARCHAR (255) NOT NULL,
	quequan VARCHAR (255) NOT NULL,
	ngaysinh DATE,
	diem INT,
	cmnd VARCHAR (255)	UNIQUE NOT NULL,
	sdt VARCHAR (255)	UNIQUE NOT NULL,
	email VARCHAR (255) UNIQUE NOT NULL
);
INSERT INTO HocSinh(mahs,hoten,quequan,ngaysinh,diem,cmnd,sdt,email)
VALUES ('21110556','Pham Thi Phuong Nghi','Ben Tre','01/09/2003',9,'083303008061','0814096656','thiphuongnghipham@gmail.com');
SELECT * FROM HocSinh
DELETE FROM HocSinh
DROP TABLE HocSinh