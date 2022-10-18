USE master
GO

IF NOT EXISTS (
    SELECT [name]
	FROM sys.databases
	WHERE [name] = N'employee_journey_map'
)

CREATE DATABASE employee_journey_map
GO

USE [employee_journey_map]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee](
	[id_employee] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[about] [text] NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[employee_feedback](
	[id_employee_feedback] [int] IDENTITY(1,1) NOT NULL,
	[id_employee] [int] NULL,
	[author] [varchar](50) NOT NULL,
	[strengths] [varchar](50) NULL,
	[minuses] [varchar](50) NULL,
	[expected_actions] [varchar](50) NULL,
	[goals] [varchar](50) NULL,
	[created_on] [datetime] NULL,
 CONSTRAINT [PK_employee_feedback] PRIMARY KEY CLUSTERED 
(
	[id_employee_feedback] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[employee_feedback]  WITH CHECK ADD  CONSTRAINT [FK_employee_feedback_employee] FOREIGN KEY([id_employee])
REFERENCES [dbo].[employee] ([id_employee])
GO

ALTER TABLE [dbo].[employee_feedback] CHECK CONSTRAINT [FK_employee_feedback_employee]
GO


CREATE TABLE [dbo].[employee_journey](
	[id_employee_journey] [int] IDENTITY(1,1) NOT NULL,
	[id_employee] [int] NULL,
	[job_position] [varchar](50) NULL,
	[salary] [money] NULL,
	[date_start] [datetime] NULL,
	[date_end] [datetime] NULL,
	[notes] [varchar](50) NULL,
 CONSTRAINT [PK_employee_journey] PRIMARY KEY CLUSTERED 
(
	[id_employee_journey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[employee_journey]  WITH CHECK ADD  CONSTRAINT [FK_employee_journey_employee] FOREIGN KEY([id_employee])
REFERENCES [dbo].[employee] ([id_employee])
GO

ALTER TABLE [dbo].[employee_journey] CHECK CONSTRAINT [FK_employee_journey_employee]
GO


