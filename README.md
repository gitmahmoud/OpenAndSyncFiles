# Database Creation Script


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NOT NULL,
	[SupplierName] [nvarchar](250) NULL,
	[Url] [nvarchar](300) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[LastSyncDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.tblProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblProduct] ON
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (1, N'Absol', N'Yxhult/Svesten AB', N'https://image-us.samsung.com/SamsungUS/home/home-appliances/dishwashers/rotary/pd/dw80r9950ug-aa/newspecsheet/DW80R9950US_V6.pdf', NULL, NULL, CAST(0x0000AACF00948915 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (2, N'Addinol Semi Synth Mv 1047', N'Addinol Lube Oil GmbH', N'http://www.addinol.de/oilfinder/show_msds.php?id=38163', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (3, N'Addinol Super Ligth Mv 0546', N'Addinol Lube Oil GmbH', N'http://www.addinol.de/oilfinder/show_msds.php?id=43475', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (4, N'Anderol 6150', N'Anderol BV', N'http://www.anderol-europe.com/images/anderol/msds/SV__ANDEROL%206150_6150_SDS_20111020__ANDEROL_.PDF', NULL, NULL, CAST(0x0000AACF0094909C AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (5, N'Anderol FGH 32', N'Anderol BV', N'http://www.anderol-europe.com/images/anderol/msds/SV__ANDEROL%20FGH%2032_FGH%2032_SDS_20111129__ANDEROL_.PDF', NULL, NULL, CAST(0x0000AACF00949193 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (6, N'Anti-static fluid', N'Xerox', N'http://www.xerox.com/download/ehs/msds/4-0071.da.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (7, N'Bell®', N'Hedegaard A/S', N'http://datablade.dlaagro.com/Bell_-_150911.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (8, N'Beskyttelsescreme', N'Care Repair', N'http://www.care-repair.dk/pdf_out/120.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (9, N'Biopower', N'Hedegaard A/S', N'http://www.middeldatabasen.dk/pdf/msds/Biopower_MSDS_20080901.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (10, N'Bison Plastlim', N'Nilfisk-Frithiof', N'http://www.nilfisk-frithiof.dk/files/pdf/produktdatablad_pvc_lim.pdf', NULL, NULL, CAST(0x0000AACF0094976D AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (11, N'Blasocut® Bc 35 Kombi', N'Duroc Machine Tools A/S', N'http://www.duroc.com/media/782154/sikkerhedsdatablad_-_blasocut_bc_35_kombi.pdf', NULL, NULL, CAST(0x0000AACF00949C48 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (12, N'Bore-Skوre-Olie (Sprayprodukt)', N'Care Repair', N'http://www.care-repair.dk/pdf_out/570.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (13, N'Briotril 400 EC', N'Hedegaard A/S', N'http://www.makhteshim-agan.nl/beheer/plaat/15207031DK%20Briotril%20400EC%20%28DK%29.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (14, N'Buffer 4.0', N'Reagecon Diagnostics Limited', N'http://www.certs.reagecon.com/msds/da_/JR_2822_15da_.pdf', NULL, NULL, CAST(0x0000AACF00949D38 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (15, N'Buffer Rlt', N'Qiagen Danmark, Filial Af Qiagen AB, Sverige', N'http://www.qiagen.com/data/Support/MSDS/DK/Buffer_RLT_DK7.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (16, N'Buffer RLT plus', N'Qiagen Danmark, Filial Af Qiagen AB, Sverige', N'http://www.qiagen.com/data/Support/MSDS/DK/Buffer_RLT_plus_DK5.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (17, N'Buffer RW1', N'Qiagen Danmark, Filial Af Qiagen AB, Sverige', N'http://www.qiagen.com/data/Support/MSDS/DK/Buffer_RW1_DK7.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (18, N'C5-A Copper Anti-Seize Stick', N'Henkel Norden AB', N'http://mymsds.henkel.com/mymsds/0006.466863.7200.sv.MSDS_UT_SE.SE.pdf', NULL, NULL, CAST(0x0000AACF0094A16D AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (19, N'Cوsium format oplّsning', N'Cabot Specialty Fluids', N'http://www.formatebrines.com/Portals/2/Datasheets/CESFORMSOL-EUR-DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (20, N'Callisto', N'Hedegaard A/S', N'http://www.syngenta.com/country/dk/da/plantebeskyttelse/produkter/ukrudtsmidler/Documents/Callisto-SDS.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (21, N'Citronsyramonohydrat Pulver Ph.eur.', N'VWR International AB', N'https://se.vwr.com/app/asset?type=hi_res&id=7670430&name=sds_VWRC85514&filename=7670430.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (22, N'Cool Down', N'Care Repair', N'http://www.care-repair.dk/pdf_out/479.pdf', N'87456709', N'chemicontrol', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (23, N'Creatine Monohydrate Biochemica', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A3132_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (24, N'Daglig Rengّring', N'Stonetreatment ApS', N'http://www.stonetreatment.dk/media/784/lba-daglig_rengoring.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (25, N'Daglig Rengّring', N'Stonetreatment ApS', N'http://www.stonetreatment.dk/media/784/lba-daglig_rengoring.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (26, N'Delaval Mastitis Test Cmt', N'DELAVAL A/S', N'http://www.delaval.dk/ImageVaultFiles/id_6409/cf_5/DeLavalMastitisTestCMT.pdf', NULL, NULL, CAST(0x0000AACF0094A8B1 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (27, N'Diammoniumperoxodisulfat', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A0834_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (28, N'DynoRex', N'Orica Denmark A/S', N'http://www.oricaminingservices.com/download/file_id_11666/', NULL, NULL, CAST(0x0000AACF0094B05C AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (29, N'Eclipse Hard Floor Sealer', N'PETER LUDVIGSEN A/S', N'http://www.peter-ludvigsen.dk/pdf/pioneer/Hard_Floor_Sealer.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (30, N'Eclipse Neutral Cleaner', N'PETER LUDVIGSEN A/S', N'http://www.peter-ludvigsen.dk/pdf/pioneer/Neutral_Cleaner.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (31, N'Edta Calibration Sample', N'Leco Corporation  Svenska AB', N'http://arkiv.lecoswe.se/pdf/MSDS/DK/502-092(DK).pdf', N'lecocust', N'pdffiles', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (32, N'Eletronic-Spray 200ml Art.: 2832', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2832_0008_03-11-2009_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (33, N'Ferodo Dot 4 Esp', N'Aktieselskabet Carl Christensen', N'http://www.msystem.dk/consumer/sikkerhedsdatablad.aspx?kid=6801', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (34, N'Flamol B', N'A B PLANTESERVICE', N'http://www.flamol.dk/Flamol%20B.pdf', NULL, NULL, CAST(0x0000AACF0094B265 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (35, N'Flamol K', N'A B PLANTESERVICE', N'http://www.flamol.dk/Flamol%20K.pdf', NULL, NULL, CAST(0x0000AACF0094B28C AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (36, N'Foodmax Bore- & Monteringspasta', N'Care Repair', N'http://www.care-repair.dk/pdf_out/H590.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (37, N'Furnace Reagent', N'Leco Corporation  Svenska AB', N'http://arkiv.lecoswe.se/pdf/MSDS/DK/501-609-HAZ(DK).pdf', N'lecocust', N'pdffiles', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (38, N'Glyphomax* Herbicide (naf-595)', N'Hedegaard A/S', N'http://www.middeldatabasen.dk/pdf/MSDS/Glyphomax_MSDS_20101029.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (39, N'Graco Pump Armor', N'GRACO N.V.', N'http://gww.graco.com/docs/MSDS/Danish/MSD029A.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (40, N'Grease Spray', N'Care Repair', N'http://www.care-repair.dk/pdf_out/H588.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (41, N'Grundrens', N'Care Repair', N'http://www.care-repair.dk/pdf_out/360.pdf', N'87456709', N'chemicontrol', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (42, N'Hakupur 19-283', N'Jens Linde A/S', N'http://jenslinde.dk/userfiles/image/PDF/HAKUPUR_19-283.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (43, N'Hydrochloric Acid 1.128 % (w/v) P. A.', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A2768_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (44, N'Hylomar Universal Blue', N'Ermax A/S', N'http://www.ermax.dk/Files/Filer/nyErmax/Servicevejledninger/hylomar_universal_blue.pdf', NULL, NULL, CAST(0x0000AACF0094D0FD AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (45, N'Hylomar Universal Blue', N'Ermax A/S', N'http://www.ermax.dk/Files/Filer/nyErmax/Servicevejledninger/hylomar_universal_blue.pdf', NULL, NULL, CAST(0x0000AACF0094D12F AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (46, N'Kalkfjerner Super', N'Care Repair', N'http://www.care-repair.dk/pdf_out/208.pdf', N'87456709', N'chemicontrol', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (47, N'Kerb 500 Sc Herbicide', N'Hedegaard A/S', N'http://planteapp.dlbr.dk/Middeldatabasen/pdf/msds/Kerb%20500SC_MSDS_20060607.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (48, N'Kt Flyvrustfjerner', N'KlarTek Danmark ApS', N'http://www.klartek.dk/datablade/1319020820__-_KT-Flugrostentferner_PKW_(DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (49, N'Kt Lawine Blau Vollwaschpulver', N'KlarTek Danmark ApS', N'http://www.klartek.dk/datablade/1320329081__-_KT_Lawine_Blau_Vollwaschpulver_(DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (50, N'Kvartssand', N'Dansk Kvarts Industri A/S', N'http://www.kvarts.dk/files/manager/kvartssand.pdf?viewer=true', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (51, N'LM 40 Multi-Funktions-Spray 400ml Art.:2816', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2816_0009_24-02-2010_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (52, N'Loctite 561', N'Henkel Norden AB', N'http://mymsds.henkel.com/mymsds/0006.540917.7200.sv.MSDS_UT_SE.pdf', NULL, NULL, CAST(0x0000AACF0094D8F2 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (53, N'Loctite 668', N'Henkel Norden AB', N'http://mymsds.henkel.com/mymsds/0006.705002.7200.sv.MSDS_UT_SE.SE.pdf', NULL, NULL, CAST(0x0000AACF0094DBE0 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (54, N'Maintenancespray White 250ml Art.:2872', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2872_0011_06-07-2009_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (55, N'Mangansulfat Monohydrat', N'Hedegaard A/S', N'http://planteapp.dlbr.dk/middeldatabasen/pdf/MSDS/Mangansulfat_32_MSDS_20091208.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (56, N'Montage-Lim', N'Care Repair', N'http://www.care-repair.dk/pdf_out/432.pdf', N'87456709', N'chemicontrol', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (57, N'Myremiddel Til Udvanding', N'TANACO DANMARK A/S ', N'http://www.tanaco.dk/cms/modules/ContentExpress/img_repository/Myremiddel%20til%20udvanding.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (58, N'Nicanor 20 Sg', N'Hedegaard A/S', N'http://www.makhteshim-agan.nl/beheer/plaat/Nicanor%2020SG%20%28H%29%20%28DK%29.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (59, N'Nitric Acid - Standard Volumetric Acid (0.5 M)', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A2690_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (60, N'Nitric Acid 20 % Technical Grade', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A0940_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (61, N'Nobelcord, F-cord 10, E-cord', N'Orica Denmark A/S', N'http://www.oricaminingservices.com/download/file_id_11755/', NULL, NULL, CAST(0x0000AACF0094E107 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (62, N'Nobelit EP', N'Orica Denmark A/S', N'http://www.oricaminingservices.com/download/file_id_11685/', NULL, NULL, CAST(0x0000AACF0094E83B AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (63, N'Notrac Museblok', N'Mortalin Produktion ApS', N'http://www.mortalin.dk/files/pdf/Notrac_Museblok_28_g_vers_2_7-3-20011.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (64, N'Notrac Museblok 28 g', N'Mortalin Produktion ApS', N'http://www.mortalin.dk/files/pdf/Notrac_Rotteblok_28_g_-_bromadiolon_-_MSDS_-vers_2_7-3-20011.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (65, N'Notrac Rotteblok 28 g', N'Mortalin Produktion ApS', N'http://www.mortalin.dk/files/pdf/Notrac_Rotteblok_28_g_-_bromadiolon_-_MSDS_-vers_2_7-3-20011.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (66, N'Opticid', N'DELAVAL A/S', N'http://www.delaval.dk/ImageVaultFiles/id_13546/cf_5/OptiCid_dk.PDF', NULL, NULL, CAST(0x0000AACF0094EA01 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (67, N'Pirimor G', N'Hedegaard A/S', N'http://www.syngenta.com/country/dk/SiteCollectionDocuments/Pirimor-SDS-DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (68, N'Potassium Dichromate - Standard Volumetric Solution (0.033 M) For Cod-determination', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A3319_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (69, N'Potassium Ferrocyanide Trihydrate P. A.', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A1867_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (70, N'Pyrethrum Mod Fluer', N'TANACO DANMARK A/S ', N'http://www.tanaco.dk/cms/modules/ContentExpress/img_repository/Pyrethrum.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (71, N'R10 Lugtfjerner', N'Trade Nordic', N'http://shop.mediqdanmark.dk/web_filer/72/72-90-R10%20sikkerhedsdatablad%20DK.pdf', NULL, NULL, CAST(0x0000AACF0094EDA9 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (72, N'Rebound Cleaner/Enhancer', N'PETER LUDVIGSEN A/S', N'http://www.peter-ludvigsen.dk/pdf/pioneer/Rebound_Cleaner.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (73, N'RTU Xtra, bag in can', N'TANACO DANMARK A/S ', N'http://www.tanaco.dk/cms/modules/ContentExpress/img_repository/RTU%20Xtra,%20bic.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (74, N'Schnellreiniger 5l', N'Auto-G Holstebro A/S', N'http://www.autog.dk/Admin/Public/DWSDownload.aspx?File=Files%2fFiler%2fDatablade%2f2824.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (75, N'Silicone Spray', N'Care Repair', N'http://www.care-repair.dk/pdf_out/H580.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (76, N'Siliconspray 300ml Art.: 2899', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2899_0009_29-06-2009_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (77, N'Silvernitrat 0,1 Mol/l (0,1 N) Vattenlِsning Avs Titrinorm® Volumetrisk  Lِsning', N'VWR International AB', N'https://se.vwr.com/app/asset?type=hi_res&id=7901949&name=sds_VWRC30472&filename=7901949.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (78, N'Sol Lotion Faktor 30', N'Care Repair', N'http://www.care-repair.dk/pdf_out/132.pdf', N'87456709', N'chemicontrol', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (79, N'Stald Chok D', N'TANACO DANMARK A/S ', N'http://www.tanaco.dk/cms/modules/ContentExpress/img_repository/Stald%20Chok.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (80, N'Stonetreatment Daglig Rengّring', N'Stonetreatment ApS', N'http://www.stonetreatment.dk/media/784/lba-daglig_rengoring.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (81, N'Stonetreatment Grundrengّring', N'Stonetreatment ApS', N'http://www.stonetreatment.dk/media/719/lba-grundrengoring.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (82, N'Stonetreatment Grundrengّring', N'Stonetreatment ApS', N'http://www.stonetreatment.dk/media/719/lba-grundrengoring.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (83, N'Super', N'DELAVAL A/S', N'http://www.delaval.dk/ImageVaultFiles/id_13553/cf_5/Super.PDF', NULL, NULL, CAST(0x0000AACF0094F1E9 AS DateTime))
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (84, N'Svovlsyre 50 %', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A2102_da_DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (85, N'SWEPCO 101 Moly Grease', N'Lubco Danmark', N'http://swepcousa.com/lubesite/lubemsds/101%20Danish.pdf', N'MSDSlube', N'$Rep1933', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (86, N'Swepco 121 Tri-Plex Universal Grease', N'Lubco Danmark', N'http://swepcousa.com/lubesite/lubemsds/121%20Danish.pdf', N'MSDSlube', N'$Rep1933', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (87, N'Swepco 815 Food Machinery Grease (Aerosol)', N'Lubco Danmark', N'http://swepcousa.com/lubesite/lubemsds/815%20Danish%20UN1950.pdf', N'MSDSlube', N'$Rep1933', NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (88, N'Tacky Lube Spray 400ml Art.:2842', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2842_0010_07-09-2010_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (89, N'Toner (sort, cyan, Magenta, gul)', N'Xerox', N'http://www.xerox.com/download/ehs/msds/3-1176.da.pdf//download/ehs/msds/3-1176.da.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (90, N'Tork Premium Flydende Sوbe - Mild', N'SCA Hygiene Products A/S', N'http://img.sca-tork.com/medias/sys_master/8833033535518.pdf?mime=application%2Fpdf&realname=420501%2C+420502%2C+400505+Mild.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (91, N'Tp 100 Forte', N'KlarTek Danmark ApS', N'http://www.klartek.dk/datablade/1319017701__-_TP_100_Spezial_(DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (92, N'TP 400 Chassis S', N'KlarTek Danmark ApS', N'http://www.klartek.dk/datablade/1319017701__-_TP_400_Chassis_S_(DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (93, N'TRAFFIC AMPERE P Farve blه og grه', N'Backner ApS', N'http://www.backner.dk/contents/da/DK_Traffic_blaa_graa.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (94, N'TRAFFIC AMPERE P Farve gul og hvid', N'Backner ApS', N'http://www.backner.dk/contents/da/DK_Traffic_gul_og_hvid.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (95, N'Traffic Ampere P Farve Rّd Og Grّn / Traffic Ampere P Extra Hvid', N'Backner ApS', N'http://www.backner.dk/contents/da/DK_Traffic_rod_gron_Traffic_Extra_hvid.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (96, N'Tris-(hydroxymethyl) Aminomethan (tris) Analar Normapur® Analyse Reagens', N'AppliChem GmbH', N'https://dk.vwr.com/app/asset?type=hi_res&id=7667805&name=sds_BDHA10315&filename=sds_BDHA10315.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (97, N'Tsl-vوske Til Halspakning', N'GRACO N.V.', N'http://www.graco.com/content/dam/graco/tech_documents/msds/da/MSD122W.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (98, N'Vask & Voks', N'KlarTek Danmark ApS', N'http://www.klartek.dk/datablade/1319017701__-_Wash_&_Wax_(DK.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (99, N'Ventil Sauber 150ml Art.: 2809', N'Auto-G Holstebro A/S', N'http://www.chemical-check.de/clientversion/pdf1/566/2809_0012_27-04-2010_DA.pdf', NULL, NULL, NULL)
INSERT [dbo].[tblProduct] ([Id], [ProductName], [SupplierName], [Url], [UserName], [Password], [LastSyncDate]) VALUES (100, N'Zinc Acetate Dihydrate P. A.', N'AppliChem GmbH', N'http://www.applichem.com/fileadmin/datenblaetter/A4324_da_DK.pdf', NULL, NULL, NULL)
GO
print 'Processed 100 total records'
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
/****** Object:  Table [dbo].[tblFile]    Script Date: 09/21/2019 09:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFile](
	[Id] [int] NOT NULL,
	[File] [varbinary](max) NULL,
 CONSTRAINT [PK_dbo.tblFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  ForeignKey [FK_tblFile_tblProduct]    Script Date: 09/21/2019 09:25:48 ******/
ALTER TABLE [dbo].[tblFile]  WITH CHECK ADD  CONSTRAINT [FK_tblFile_tblProduct] FOREIGN KEY([Id])
REFERENCES [dbo].[tblProduct] ([Id])
GO
ALTER TABLE [dbo].[tblFile] CHECK CONSTRAINT [FK_tblFile_tblProduct]
GO
