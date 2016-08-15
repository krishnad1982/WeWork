SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Emp](
	[empId] [int] NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[address] [varchar](150) NULL,
	[mStatusId] [int] NULL,
	[idNo] [int] NULL,
	[taxNo] [int] NULL,
	[pEmailId] [varchar](100) NULL,
	[oEmailId] [varchar](100) NULL,
	[bankId] [int] NULL,
	[accNo] [int] NULL,
	[accTypeId] [int] NULL,
	[bankCode] [int] NULL,
	[emerName] [varchar](100) NULL,
	[emerNumber1] [int] NULL,
	[emerNumber2] [int] NULL,
	[jobTitle] [varchar](50) NULL,
	[provinceId] [int] NULL,
	[countryId] [nchar](10) NULL,
	[cityName] [varchar](50) NULL,
	[jobTypeId] [int] NULL,
	[supId] [int] NULL,
	[notes] [varchar](200) NULL,
	[empRoleId] [int] NULL,
	[empStatusId] [int] NULL,
	[basicSalary] [int] NULL,
	[oAllowance1] [int] NULL,
	[extNo] [int] NULL,
	[carReg] [varchar](50) NULL,
	[officeNo] [int] NULL,
	[homeNo] [int] NULL,
	[cellNo] [int] NULL,
	[dob] [date] NULL,
	[oAllowance2] [int] NULL,
	[oAllowance3] [int] NULL,
	[ethnicityId] [int] NULL,
	[crtUserId] [int] NULL,
	[mdfUserId] [int] NULL,
	[crtDate] [datetime] NULL,
	[mdfDate] [datetime] NULL,
 CONSTRAINT [PK_Emp] PRIMARY KEY CLUSTERED 
(
	[empId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO