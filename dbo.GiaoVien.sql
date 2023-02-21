CREATE TABLE [dbo].[GiaoVien] (
    [magv]     VARCHAR (10)  UNIQUE NOT NULL,
    [hoten]    VARCHAR (100) NOT NULL,
    [quequan]  VARCHAR (200) NOT NULL,
    [ngaysinh] DATETIME      NOT NULL,
    [email]    VARCHAR (100) UNIQUE NOT NULL,
    [sdt]      VARCHAR (20)  UNIQUE NOT NULL
);

