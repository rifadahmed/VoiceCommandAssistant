CREATE TABLE [dbo].[datatable] (
    [loginId]  INT          IDENTITY (1, 1) NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    [status]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([loginId] ASC)
);

