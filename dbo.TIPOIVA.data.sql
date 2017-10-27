SET IDENTITY_INSERT [dbo].[TIPOIVA] ON
INSERT INTO [dbo].[TIPOIVA] ([ID], [tipoiva], [descrip], [abrevia], [porcen1], [porcen2], [cuenta1], [cuenta2], [abc]) VALUES (2, 19, N' IVA.10,5 %', N'INSC ', CAST(10.50 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), N'113040900 ', N'001', N'A')
SET IDENTITY_INSERT [dbo].[TIPOIVA] OFF
