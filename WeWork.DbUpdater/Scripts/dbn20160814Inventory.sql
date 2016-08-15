SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Inventory](
	[invId] [int] NOT NULL,
	[invName] [varchar](50) NULL,
	[invModel] [varchar](50) NULL,
	[serialNo] [int] NULL,
	[specsDesc] [varchar](100) NULL,
	[softInstalled] [varchar](200) NULL,
	[softSerialNo] [int] NULL,
	[addAccess] [varchar](200) NULL,
	[itemPrice] [numeric](18, 0) NULL,
	[empId] [int] NULL,
	[crtUserId] [int] NULL,
	[mdfUserId] [int] NULL,
	[crtDate] [int] NULL,
	[mdfDate] [int] NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[invId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO