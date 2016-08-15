SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MedAid](
	[medAidId] [int] NOT NULL,
	[medAidName] [varchar](50) NULL,
	[medAidNo] [varchar](50) NULL,
	[medPlan] [varchar](50) NULL,
	[dep1Name] [varchar](50) NULL,
	[dep2Name] [varchar](50) NULL,
	[dep3Name] [varchar](50) NULL,
	[dep4Name] [varchar](50) NULL,
	[dep5Name] [varchar](50) NULL,
	[dep6Name] [varchar](50) NULL,
	[addBenefitsId] [int] NULL,
	[crtUserId] [int] NULL,
	[mdfUserId] [int] NULL,
	[crtDate] [datetime] NULL,
	[mdfDate] [datetime] NULL,
 CONSTRAINT [PK_MedAid] PRIMARY KEY CLUSTERED 
(
	[medAidId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO