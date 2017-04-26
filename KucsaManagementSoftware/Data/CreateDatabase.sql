DROP TABLE IF EXISTS [dbo].[TblProject];
GO

DROP TABLE IF EXISTS [dbo].[TblMember];	
GO

DROP TABLE IF EXISTS [dbo].[TblRole];	
GO

DROP TABLE IF EXISTS [dbo].[TblModule];
GO

DROP TABLE IF EXISTS [dbo].[TblLanguage];
GO

DROP TABLE IF EXISTS [dbo].[TblCourse];
GO

CREATE TABLE [dbo].[TblCourse] (
    [CourseId]      INT           IDENTITY (1, 1) NOT NULL,
    [CourseName]    VARCHAR (100) NOT NULL,
    [CourseFaculty] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([CourseId] ASC),
    UNIQUE NONCLUSTERED ([CourseName] ASC)
);

Go

CREATE TABLE [dbo].[TblLanguage] (
    [LanguageId]        INT            IDENTITY (1, 1) NOT NULL,
    [Language]          VARCHAR (100)  NOT NULL,
    [LanguageAuthor]    NVARCHAR (50)  NULL,
    [LanguageWebsite]   NVARCHAR (250) NULL,
    [LanguageTuitorial] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([LanguageId] ASC),
    UNIQUE NONCLUSTERED ([Language] ASC)
);



GO

CREATE TABLE [dbo].[TblModule] (
    [ModuleId]     INT           IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (100) NOT NULL,
    [ModuleLeader] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ModuleId] ASC),
    UNIQUE NONCLUSTERED ([Title] ASC)
);



GO

CREATE TABLE [dbo].[TblRole] (
    [RoleId]   INT           IDENTITY (1, 1) NOT NULL,
    [RoleName] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([RoleId] ASC),
    UNIQUE NONCLUSTERED ([RoleName] ASC)
);



GO

CREATE TABLE [dbo].[TblMember] (
    [MemberId]           INT           IDENTITY (1, 1) NOT NULL,
    [MemberName]         VARCHAR (100) NOT NULL,
    [Password]         VARCHAR (100) NOT NULL,
    [MemberRegistration] VARCHAR (100) NOT NULL,
    [MemberThumbnail]    IMAGE         NULL,
    [MemberBigPicture]   IMAGE         NULL,
    [CourseId]           INT           NOT NULL,
    [ModuleId]           INT           NULL,
    [RoleId]             INT           NOT NULL,
    [TimeJoined]         ROWVERSION    NOT NULL,
    PRIMARY KEY CLUSTERED ([MemberId] ASC),
    UNIQUE NONCLUSTERED ([MemberRegistration] ASC),
    UNIQUE NONCLUSTERED ([MemberName] ASC),
    CONSTRAINT [FK_TblMember_TblRole] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[TblRole] ([RoleId]),
    CONSTRAINT [FK_TblMember_TblModule] FOREIGN KEY ([ModuleId]) REFERENCES [dbo].[TblModule] ([ModuleId]),
    CONSTRAINT [FK_TblMember_TblCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[TblCourse] ([CourseId])
);



GO

CREATE TABLE [dbo].[TblProject] (
    [ProjectId]        INT           IDENTITY (1, 1) NOT NULL,
    [ProjectTitle]     VARCHAR (100) NOT NULL,
    [ProjectDesc]      VARCHAR (MAX) NOT NULL,
    [ProjectLink]      VARCHAR (250) NOT NULL,
    [ProjectThumbnail] IMAGE         NULL,
    [ProjectBigPic]    IMAGE         NULL,
    [LanguageId]       INT           NOT NULL,
    [MemberId]         INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ProjectId] ASC),
    UNIQUE NONCLUSTERED ([ProjectTitle] ASC),
    CONSTRAINT [FK_TblProject_TblLanguage] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[TblLanguage] ([LanguageId]),
    CONSTRAINT [FK_TblProject_TblMember] FOREIGN KEY ([MemberId]) REFERENCES [dbo].[TblMember] ([MemberId])
);

GO

INSERT INTO dbo.TblCourse
        ( CourseName, CourseFaculty )
VALUES  ( 'Software Engineering', -- CourseName - varchar(100)
          'FIST'  -- CourseFaculty - varchar(100)
          )
INSERT INTO dbo.TblCourse
        ( CourseName, CourseFaculty )
VALUES  ( 'Computer Science', -- CourseName - varchar(100)
          'FIST'  -- CourseFaculty - varchar(100)
          )
INSERT INTO dbo.TblCourse
        ( CourseName, CourseFaculty )
VALUES  ( 'Applied Computer Science', -- CourseName - varchar(100)
          'FIST'  -- CourseFaculty - varchar(100)
          )

GO

INSERT INTO dbo.TblLanguage
        ( Language ,
          LanguageAuthor ,
          LanguageWebsite ,
          LanguageTuitorial
        )
VALUES  ( 'CSharp' , -- Language - varchar(100)
          N'John Doe' , -- LanguageAuthor - nvarchar(50)
          N'www.msdn.com' , -- LanguageWebsite - nvarchar(250)
          N'kedevelopers.com/csharp'  -- LanguageTuitorial - nvarchar(50)
        )
INSERT INTO dbo.TblLanguage
        ( Language ,
          LanguageAuthor ,
          LanguageWebsite ,
          LanguageTuitorial
        )
VALUES  ( 'Java' , -- Language - varchar(100)
          N'James Smith' , -- LanguageAuthor - nvarchar(50)
          N'www.oracle.com' , -- LanguageWebsite - nvarchar(250)
          N'kedevelopers.com/java'  -- LanguageTuitorial - nvarchar(50)
        )

GO

INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Chair'  -- RoleName - varchar(100)
          )
INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Vice'  -- RoleName - varchar(100)
          )
INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Org. Sec.'  -- RoleName - varchar(100)
          )
INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Secretary'  -- RoleName - varchar(100)
          )
INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Treasurer'  -- RoleName - varchar(100)
          )
INSERT INTO dbo.TblRole
        ( RoleName )
VALUES  ( 'Member'  -- RoleName - varchar(100)
          )

GO

INSERT INTO dbo.TblModule
        ( Title, ModuleLeader )
VALUES  ( 'Microsoft CSharp', -- Title - varchar(100)
          'Joseph Githithu'  -- ModuleLeader - varchar(100)
          )
INSERT INTO dbo.TblModule
        ( Title, ModuleLeader )
VALUES  ( 'Google Android', -- Title - varchar(100)
          'Benson Okiora'  -- ModuleLeader - varchar(100)
          )

GO

INSERT INTO dbo.TblMember
        ( MemberName ,
          Password ,
          MemberRegistration ,
          MemberThumbnail ,
          MemberBigPicture ,
          CourseId ,
          ModuleId ,
          RoleId
        )
VALUES  ( 'Joseph Githithu' , -- MemberName - varchar(100)
          '2345' , -- Password - varchar(100)
          'in16/20143/13' , -- MemberRegistration - varchar(100)
          NULL , -- MemberThumbnail - image
          NULL , -- MemberBigPicture - image
          1 , -- CourseId - int
          1 , -- ModuleId - int
          5  -- RoleId - int
        )
INSERT INTO dbo.TblMember
        ( MemberName ,
          Password ,
          MemberRegistration ,
          MemberThumbnail ,
          MemberBigPicture ,
          CourseId ,
          ModuleId ,
          RoleId
        )
VALUES  ( 'Benson Okiora' , -- MemberName - varchar(100)
          '4356' , -- Password - varchar(100)
          'INP16/20357/13' , -- MemberRegistration - varchar(100)
          NULL , -- MemberThumbnail - image
          NULL , -- MemberBigPicture - image
          1 , -- CourseId - int
          2 , -- ModuleId - int
          1  -- RoleId - int
        )
INSERT INTO dbo.TblMember
        ( MemberName ,
          Password ,
          MemberRegistration ,
          MemberThumbnail ,
          MemberBigPicture ,
          CourseId ,
          ModuleId ,
          RoleId
        )
VALUES  ( 'Gabriel Otenyo' , -- MemberName - varchar(100)
          '3456' , -- Password - varchar(100)
          'IN16/20168/13' , -- MemberRegistration - varchar(100)
          NULL , -- MemberThumbnail - image
          NULL , -- MemberBigPicture - image
          1 , -- CourseId - int
          2 , -- ModuleId - int
          1  -- RoleId - int
        )

GO

INSERT INTO dbo.TblProject
        ( ProjectTitle ,
          ProjectDesc ,
          ProjectLink ,
          ProjectThumbnail ,
          ProjectBigPic ,
          LanguageId ,
          MemberId
        )
VALUES  ( 'Kucsa Desktop Management' , -- ProjectTitle - varchar(100)
          'A windows form software to help manage the KUCSA members operations' , -- ProjectDesc - varchar(max)
          'www.kedevelopers.com/kucsamanagementsoftware' , -- ProjectLink - varchar(250)
          NULL , -- ProjectThumbnail - image
          NULL , -- ProjectBigPic - image
          1 , -- LanguageId - int
          1  -- MemberId - int
        )
INSERT INTO dbo.TblProject
        ( ProjectTitle ,
          ProjectDesc ,
          ProjectLink ,
          ProjectThumbnail ,
          ProjectBigPic ,
          LanguageId ,
          MemberId
        )
VALUES  ( 'Kucsa Android App' , -- ProjectTitle - varchar(100)
          'An android mobile app to help manage the KUCSA members operations' , -- ProjectDesc - varchar(max)
          'www.kedevelopers.com/kucsaandroidapp' , -- ProjectLink - varchar(250)
          NULL , -- ProjectThumbnail - image
          NULL , -- ProjectBigPic - image
          1 , -- LanguageId - int
          1  -- MemberId - int
        )
