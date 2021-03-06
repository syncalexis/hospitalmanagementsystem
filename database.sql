USE [HOSPITAMIS]
GO
/****** Object:  Table [dbo].[tbladmin]    Script Date: 7/25/2019 8:40:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbladmin](
	[userName] [varchar](50) NULL,
	[passWord] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblpatient]    Script Date: 7/25/2019 8:40:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblpatient](
	[name] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[age] [varchar](50) NULL,
	[sex] [varchar](50) NULL,
	[blood_type] [varchar](50) NULL,
	[nationality] [varchar](50) NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
