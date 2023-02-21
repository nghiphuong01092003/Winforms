CREATE TABLE [dbo].[HocSinh] (
    [masv]     VARCHAR (10)  UNIQUE NOT NULL,
    [ten]      VARCHAR (100) NOT NULL,
    [quequan]  VARCHAR (255) NOT NULL,
    [ngaysinh] DATETIME      NOT NULL,
    [cmnd]     VARCHAR (100) UNIQUE NOT NULL,
    [email]    VARCHAR (100) UNIQUE NOT NULL,
    [sdt]      VARCHAR (20)  UNIQUE NOT NULL
);

