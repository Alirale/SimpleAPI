CREATE TABLE [dbo].[Items] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [CreatedAt] DATETIME2 NOT NULL DEFAULT (SYSUTCDATETIME()),
    [Name] NVARCHAR(200) NOT NULL,
    [Category] VARCHAR(50) NOT NULL,
    [Description] NVARCHAR(MAX) NULL,
    [UnitPrice] DECIMAL(18,2) NOT NULL,
    [Quantity] INT NOT NULL
);



CREATE TABLE [dbo].[Users] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [UserName] NVARCHAR(50) NOT NULL UNIQUE,
    [FirstName] NVARCHAR(100) NOT NULL,
    [LastName] NVARCHAR(100) NOT NULL,
    [MobileNumber] NVARCHAR(20) NULL,
    [Email] NVARCHAR(100) NULL,
    [Password] NVARCHAR(256) NOT NULL
);


CREATE OR ALTER PROCEDURE dbo.[User_Get]
    @UserName NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (1)
        Id, UserName, FirstName, MobileNumber, LastName, Email, Password
    FROM dbo.Users
    WHERE UserName = @UserName;
END
GO


CREATE OR ALTER PROCEDURE dbo.[User_Validate]
    @UserName NVARCHAR(50),
    @Password NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Id, UserName, FirstName, MobileNumber, LastName, Email, Password
    FROM dbo.Users
    WHERE UserName = @UserName
      AND Password = @Password;
END
GO


CREATE OR ALTER PROCEDURE dbo.[User_Insert]
    @FirstName    NVARCHAR(100),
    @LastName     NVARCHAR(100),
    @Email        NVARCHAR(100) = NULL,
    @UserName     NVARCHAR(50),
    @Password     NVARCHAR(256),
    @MobileNumber NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.Users WHERE UserName = @UserName)
    BEGIN
        RAISERROR (N'Username already exists.', 16, 1);
        RETURN;
    END

    INSERT INTO dbo.Users (UserName, FirstName, LastName, MobileNumber, Email, Password)
    VALUES (@UserName, @FirstName, @LastName, @MobileNumber, @Email, @Password);

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS NewId;
END
GO



CREATE OR ALTER PROCEDURE dbo.Item_Search
    @Name     NVARCHAR(200) = NULL,
    @Category VARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        i.Id,
        i.CreatedAt,
        i.Name,
        i.Category,
        i.Description,
        i.UnitPrice,
        i.Quantity
    FROM dbo.Items i
    WHERE (@Name IS NULL OR i.Name LIKE N'%' + @Name + N'%')
      AND (@Category IS NULL OR @Category = N'' OR i.Category = @Category)
    ORDER BY i.CreatedAt DESC, i.Id DESC;
END
GO

select * from Items
where Name LIKE N'%ساعت %'


CREATE OR ALTER PROCEDURE dbo.Item_GetById
    @Id INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        i.Id,
        i.CreatedAt,
        i.Name,
        i.Category,
        i.Description,
        i.UnitPrice,
        i.Quantity
    FROM dbo.Items i
    WHERE (@Id IS NULL OR @Id = 0 OR i.Id = @Id)
	order by CreatedAt desc
END
GO


CREATE OR ALTER PROCEDURE dbo.Item_Insert
    @Name        NVARCHAR(200),
    @Category    VARCHAR(50),
    @Description NVARCHAR(MAX) = NULL,
    @UnitPrice   DECIMAL(18,2),
    @Quantity    INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Items (Name, Category, Description, UnitPrice, Quantity)
    VALUES (@Name, @Category, @Description, @UnitPrice, @Quantity);

    SELECT CAST(SCOPE_IDENTITY() AS INT) AS NewId;
END
GO


CREATE OR ALTER PROCEDURE dbo.Item_Update
    @Id          INT,
    @Name        NVARCHAR(200),
    @Category    VARCHAR(50),
    @Description NVARCHAR(MAX) = NULL,
    @UnitPrice   DECIMAL(18,2),
    @Quantity    INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Items
    SET
        Name        = @Name,
        Category    = @Category,
        Description = @Description,
        UnitPrice   = @UnitPrice,
        Quantity    = @Quantity
    WHERE Id = @Id;

    SELECT CASE WHEN @@ROWCOUNT > 0 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Succeeded;
END
GO

CREATE OR ALTER PROCEDURE dbo.Item_Delete
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.Items WHERE Id = @Id;

    SELECT CASE WHEN @@ROWCOUNT > 0 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS Succeeded;
END
GO



WITH S AS (
    SELECT N'تی‌شرت مردانه'        AS [Name], N'Clothes'        AS CatName, N'نخی، سایز L'              AS [Description], CAST( 350000     AS DECIMAL(18,2)) AS UnitPrice, 0 AS Quantity UNION ALL
    SELECT N'شلوار جین',                    N'Clothes',                 N'آبی تیره',                         950000,                               10 UNION ALL
    SELECT N'گوشی هوشمند',                  N'Electronics',             N'128GB، دو سیم‌کارت',              18500000,                             20 UNION ALL
    SELECT N'هدفون بی‌سیم',                 N'Electronics',             N'بلوتوث 5.3',                      2300000,                              30 UNION ALL
    SELECT N'برنج هاشمی 10 کیلویی',         N'Food',                    N'عطرمحلی',                         1980000,                              10 UNION ALL
    SELECT N'روغن زیتون 1 لیتری',           N'Food',                    N'فرابکر',                          520000,                               10 UNION ALL
    SELECT N'صندلی اداری',                  N'Furniture',               N'ارگونومیک، مش',                   4200000,                              10 UNION ALL
    SELECT N'میز تحریر',                    N'Furniture',               N'120×60 ام‌دی‌اف',                 3100000,                              50 UNION ALL
    SELECT N'دفتر 100 برگ',                 N'Stationery',              N'خط‌دار',                          45000,                                60 UNION ALL
    SELECT N'خودکار آبی',                   N'Stationery',              N'نوک 0.7',                         18000,                                70 UNION ALL
    SELECT N'آچار فرانسه',                  N'Tools',                   N'10 اینچ',                         270000,                               30 UNION ALL
    SELECT N'دریل برقی',                    N'Tools',                   N'600 وات',                         2150000,                              20 UNION ALL
    SELECT N'لِگو 500 تکه',                 N'Toys',                    N'مناسب ۶+',                        1350000,                              10 UNION ALL
    SELECT N'کتاب برنامه‌نویسی C#',        N'Books',                   N'چاپ ۱۴۰۳',                        420000,                               40 UNION ALL
    SELECT N'توپ فوتبال',                   N'Sports',                  N'سایز ۵',                          380000,                               60 UNION ALL
    SELECT N'سشوار خانگی',                  N'HomeAppliances',          N'۲۰۰۰ وات',                        1150000,                              30 UNION ALL
    SELECT N'عینک آفتابی',                  N'Accessories',             N'UV400',                            620000,                               50 UNION ALL
    SELECT N'کِرِم مرطوب‌کننده',           N'Beauty',                  N'پوست خشک',                        210000,                               10 UNION ALL
    SELECT N'تب‌سنج دیجیتال',               N'Medicine',                N'غیـر پزشکی (OTC)',               290000,                               10
)
INSERT INTO dbo.Items (Name, Category, Description, UnitPrice, Quantity)
SELECT s.[Name], s.CatName, s.[Description], s.UnitPrice, s.Quantity
FROM S s;


