USE [master]
GO
/****** Object:  Database [PathIdentifyEquipDemoDB]    Script Date: 09/08/2015 09:15:32 ******/
CREATE DATABASE [PathIdentifyEquipDemoDB] 
GO
USE [PathIdentifyEquipDemoDB]
GO
/****** Object:  Table [dbo].[T_ReceiveData]    Script Date: 09/08/2015 09:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_ReceiveData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EquipId] [int] NOT NULL,
	[VehPlateNo] [varchar](50) NOT NULL,
	[VehPlateColor] [varchar](50) NOT NULL,
	[VehicleSpeed] [int] NOT NULL,
	[ReachTime] [datetime] NOT NULL,
	[VehicleLength] [float] NULL,
	[ImageAllPath] [varchar](150) NULL,
	[ImageNearPath] [varchar](150) NULL,
	[ImagePlateNoPath] [varchar](150) NULL,
	[ImageBinPlateNoPath] [varchar](150) NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_T_ReceiveData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_PathIdentifyEquip]    Script Date: 09/08/2015 09:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_PathIdentifyEquip](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[EquipName] [varchar](150) NOT NULL,
	[Ip] [varchar](50) NULL,
	[Port] [int] NULL,
	[LoginUserName] [varchar](50) NULL,
	[LoginPwd] [varchar](18) NULL,
	[ProtocolId] [int] NOT NULL,
	[EquipType] [int] NOT NULL,
	[Mile] [varchar](80) NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_T_PathIdentifyEquip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_DeviceStatusLog]    Script Date: 09/08/2015 09:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_DeviceStatusLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EquipId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[StatusDesc] [varchar](150) NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_T_DeviceStatusLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_DataDict]    Script Date: 09/08/2015 09:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_DataDict](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[FValue] [int] NOT NULL,
	[FDesc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_DataDict] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_T_ReceiveData_VehPlateNo]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_ReceiveData] ADD  CONSTRAINT [DF_T_ReceiveData_VehPlateNo]  DEFAULT ('未识别') FOR [VehPlateNo]
GO
/****** Object:  Default [DF_T_ReceiveData_VehPlateColor]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_ReceiveData] ADD  CONSTRAINT [DF_T_ReceiveData_VehPlateColor]  DEFAULT ('未识别') FOR [VehPlateColor]
GO
/****** Object:  Default [DF_T_ReceiveData_CreateTime]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_ReceiveData] ADD  CONSTRAINT [DF_T_ReceiveData_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF_T_PathIdentifyEquip_ParentId]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_PathIdentifyEquip] ADD  CONSTRAINT [DF_T_PathIdentifyEquip_ParentId]  DEFAULT ((-1)) FOR [ParentId]
GO
/****** Object:  Default [DF_T_PathIdentifyEquip_CreateTime]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_PathIdentifyEquip] ADD  CONSTRAINT [DF_T_PathIdentifyEquip_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF_T_DeviceStatusLog_CreateTime]    Script Date: 09/08/2015 09:15:33 ******/
ALTER TABLE [dbo].[T_DeviceStatusLog] ADD  CONSTRAINT [DF_T_DeviceStatusLog_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO


INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'DriverType', N'1', N'汉王');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'DriverType', N'2', N'信路威');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'DriverType', N'3', N'哈工大');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'EquipType', N'0', N'识别器');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'EquipType', N'1', N'摄像机');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'0', N'正常');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'1', N'摄像机断开');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'2', N'识别器断开');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'3', N'设备组断开');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'4', N'识别器故障');
GO
INSERT INTO [dbo].[T_DataDict] ([FName], [FValue], [FDesc]) VALUES (N'StatusType', N'-999', N'未知状态');
GO
