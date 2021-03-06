USE [QLTT]
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 1/5/2022 10:21:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[TenTaiKhoan] [varchar](10) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[VaiTro] [varchar](10) NULL,
 CONSTRAINT [pk_tblThuThu] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 1/5/2022 10:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MaSinhVien] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [varchar](10) NULL,
	[SoDienThoai] [int] NULL,
	[Nganh] [nvarchar](50) NULL,
	[Khoa] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](30) NULL,
 CONSTRAINT [pk_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblThongTinThucTap]    Script Date: 1/5/2022 10:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongTinThucTap](
	[STT] [nvarchar](5) NOT NULL,
	[MaSinhVien] [nvarchar](10) NULL,
	[GiangVienHuongDan] [nvarchar](30) NULL,
	[DeTaiThucTap] [nvarchar](50) NULL,
	[CongTyThucTap] [nvarchar](50) NULL,
	[NgayBatDauThucTap] [nvarchar](10) NULL,
	[NgayKetThucThucTap] [nvarchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblThongTinThucTap] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
