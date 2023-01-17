DBCC CHECKIDENT([Station], RESEED, 0)
DBCC CHECKIDENT(RouteOfTrain, RESEED, 0)
DBCC CHECKIDENT([Train], RESEED, 0)


SET IDENTITY_INSERT [dbo].[RouteOfTrain] ON
INSERT INTO [dbo].[RouteOfTrain] ([Id], [NbRoute]) VALUES (1, 1)
INSERT INTO [dbo].[RouteOfTrain] ([Id], [NbRoute]) VALUES (2, 3)
INSERT INTO [dbo].[RouteOfTrain] ([Id], [NbRoute]) VALUES (3, 6)
INSERT INTO [dbo].[RouteOfTrain] ([Id], [NbRoute]) VALUES (4, 14)
INSERT INTO [dbo].[RouteOfTrain] ([Id], [NbRoute]) VALUES (5, 4)
SET IDENTITY_INSERT [dbo].[RouteOfTrain] OFF


SET IDENTITY_INSERT [dbo].[Station] ON
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (1, N'Mairie de Saint-Ouen', N'7 pl Rpublique, 93400 Saint Ouen', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (2, N'Saint-Ouen', N'Rue du Docteur Bauer, 93400 Saint-Ouen-sur-Seine', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (3, N'Porte de Clichy', N'3 BD Berthier, 75017 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (4, N'Pont Cardinet', N'Rue Jouffroy d''Abbans, 75017 17me Arrondissement
', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (5, N'Saint-Lazare', N'Rue Saint-Lazare, 75009 9me Arrondissement ', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (6, N'Madeleine', N'11 Rue du Chevalier de Saint-George, 75008 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (7, N'Pyramides', N'Saint-Honor, Rue des Pyramides, 75001 1er Arrondissement', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (8, N'Châtelet', N'104 Rue de Rivoli, 75001 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (9, N'Gare de Lyon', N'Place Louis Armand, 75012 Paris
', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (10, N'Cour Saint-Émilion', N'Parc de Bercy, 75012 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (11, N'Bibliothèque François-Mitterrand ', N'Tolbiac Street, 75013 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (12, N'Olympiades', N'91 r Tolbiac, 75013 Paris', 2)
SET IDENTITY_INSERT [dbo].[Station] OFF
SET IDENTITY_INSERT [dbo].[Station] ON
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (1, N'Mairie de Saint-Ouen', N'7 pl Rpublique, 93400 Saint Ouen', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (2, N'Saint-Ouen', N'Rue du Docteur Bauer, 93400 Saint-Ouen-sur-Seine', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (3, N'Porte de Clichy', N'3 BD Berthier, 75017 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (4, N'Pont Cardinet', N'Rue Jouffroy d''Abbans, 75017 17me Arrondissement
', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (5, N'Saint-Lazare', N'Rue Saint-Lazare, 75009 9me Arrondissement ', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (6, N'Madeleine', N'11 Rue du Chevalier de Saint-George, 75008 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (7, N'Pyramides', N'Saint-Honor, Rue des Pyramides, 75001 1er Arrondissement', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (8, N'Châtelet', N'104 Rue de Rivoli, 75001 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (9, N'Gare de Lyon', N'Place Louis Armand, 75012 Paris
', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (10, N'Cour Saint-Émilion', N'Parc de Bercy, 75012 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (11, N'Bibliothèque François-Mitterrand ', N'Tolbiac Street, 75013 Paris', 2)
INSERT INTO [dbo].[Station] ([Id], [Name], [Place], IdRoute) VALUES (12, N'Olympiades', N'91 r Tolbiac, 75013 Paris', 2)
SET IDENTITY_INSERT [dbo].[Station] OFF


SET IDENTITY_INSERT [dbo].[Train] ON
INSERT INTO [dbo].[Train] ([Id], [Matricule], [Capacity], [Color], [Speed], [IdRoute], [StationId]) VALUES (1, N'TX023', 150, N'Blue', 200, 4, 1)
INSERT INTO [dbo].[Train] ([Id], [Matricule], [Capacity], [Color], [Speed], [IdRoute], [StationId]) VALUES (2, N'TX123', 100, N'White', 150, 4, 2)
SET IDENTITY_INSERT [dbo].[Train] OFF