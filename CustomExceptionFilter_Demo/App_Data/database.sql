
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Office] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[ExceptionLogger](
	[ExceptionId] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionMessage] [nvarchar](max) NULL,
	[ControllerName] [nvarchar](100) NULL,
	[ActionName] [nvarchar](100) NULL,
	[ExceptionStackTrack] [nvarchar](max) NULL,
	[ExceptionLogTime] [datetime] NULL,
 CONSTRAINT [PK_ExceptionLogger] PRIMARY KEY CLUSTERED 
(
	[ExceptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO