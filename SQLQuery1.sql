CREATE TABLE GiaoVien(
	hoten varchar(100),
	diachi varchar(200),
	sdt varchar(20),
	email varchar(100),
	ngaysinh datetime
);
INSERT INTO GiaoVien(hoten,diachi,sdt,email,ngaysinh)
VALUES ('NMD','hcm','123','dnm.email.com',01/01/1980)

INSERT INTO GiaoVien(hoten,diachi,sdt,email,ngaysinh)
VALUES ('NTVH','hn','456','hntv.email.com',01/01/1983)

INSERT INTO GiaoVien(hoten,diachi,sdt,email,ngaysinh)
VALUES ('NTS','hcm','789','snt.email.com',01/01/1975)

INSERT INTO GiaoVien(hoten,diachi,sdt,email,ngaysinh)
VALUES ('NTA','bd','101112','ant.email.com',01/01/1985)

SELECT*FROM GiaoVien