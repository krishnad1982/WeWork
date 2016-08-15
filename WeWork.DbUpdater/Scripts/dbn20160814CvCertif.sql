SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CvCertif](
	[cvcertifId] [int] NOT NULL,
	[empId] [int] NULL,
	[instName] [varchar](100) NULL,
	[dateCertified] [date] NULL,
	[certifType] [varchar](20) NULL,
	[filepath] [binary](100) NULL,
	[crtUserId] [int] NULL,
	[mdfUserId] [int] NULL,
	[crtDate] [int] NULL,
	[mdfDate] [int] NULL,
 CONSTRAINT [PK_CvCertif] PRIMARY KEY CLUSTERED 
(
	[cvcertifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


