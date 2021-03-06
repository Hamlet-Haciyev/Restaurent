USE [DirectListDb]
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Image], [FullName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [CreatedDate], [Text]) VALUES (N'813e54db-9227-47a3-ab69-4b2dc59e5330', N'CustomUser', N'cd4c4a09-91b0-417c-b2d3-cf70d149f24e-202112310030SS-thumb-4.jpg', N'Ethan Moore', N'ethanmoore@gmail.com', N'ETHANMOORE@GMAIL.COM', N'ethanmoore@gmail.com', N'ETHANMOORE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOpN7mJscaVNFN1TQ0I91kQA+Jq8cjdN4GdB5Tu0UjyCMl+nnc/j3hRB3SeGYqOaPQ==', N'T2IXIERVOYLIQG3VD2C6MZYBORRKV5UN', N'e657a577-6601-4ab4-ba06-72177cce95d8', NULL, 0, 0, NULL, 1, 0, CAST(N'2021-12-31T00:30:59.7892833' AS DateTime2), N'Nullam ultricies, velit ut varius molestie, ante metus condimentum nisi, dignissim facilisis turpis ex in libero. Sed porta ante tortor, a pulvinar mi facilisis nec. Proin finibus dolor ac convallis congue.')
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Description], [CreatedDate], [About]) VALUES (11, N'3f16de54-47db-45c6-94c8-e8b672423b37-202112281529SS-dp-2.jpg', N'Take a Look at Hotels for All Budgets -- Norway', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', CAST(N'2021-12-28T15:29:11.0000000' AS DateTime2), N'Sed sed tristique nibh iam porta volutpat finibus. Donec in aliquet urneget mattis lorem. Pellentesque pellentesque')
INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Description], [CreatedDate], [About]) VALUES (12, N'4c1e866d-e659-4081-9f6a-5496578f2a13-202112281536SS-dp-3.jpg', N'The 50 Greatest Street Arts In London -- England', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', CAST(N'2021-12-28T15:36:20.0000000' AS DateTime2), N'Sed sed tristique nibh iam porta volutpat finibus. Donec in aliquet urneget mattis lorem. Pellentesque pellentesque')
INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Description], [CreatedDate], [About]) VALUES (13, N'6d849530-21f0-483c-9581-ef422ced449c-202112281541SS-dp-4.jpg', N'Take a Look at Hotels for All Budgets -- Paris', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', CAST(N'2021-12-28T15:41:27.0000000' AS DateTime2), N'Sed sed tristique nibh iam porta volutpat finibus. Donec in aliquet urneget mattis lorem. Pellentesque pellentesque')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogComments] ON 

INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (3, N'Hamlet', N'hamilet75@gmail.com', N'JBSKHLAVAFS', N'Men Web Developer olacam.', CAST(N'2021-12-29T14:56:34.5845685' AS DateTime2), 12, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (4, N'Asif', N'asif.quluyev00@gmail.com', N'Asif Devops', N'Programmer', CAST(N'2021-12-28T15:54:58.1361169' AS DateTime2), 12, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (8, N'Hamlet', N'hamilet75@gmail.com', N'Hamlet ', N'sad', CAST(N'2021-12-29T16:28:54.1618238' AS DateTime2), 12, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (16, N'Shahin', N'shahin@gmail.com', N'JBSKHLAVAFS', N'asd', CAST(N'2022-01-02T13:13:11.6991515' AS DateTime2), 12, 8)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (17, N'Asif', N'asif.quluyev00@gmail.com', N'Asif Devops', N'asd', CAST(N'2022-01-02T14:43:43.9391515' AS DateTime2), 12, 8)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (18, N'Hamlet', N'hamilet75@gmail.com', N'asd', N'asd', CAST(N'2022-01-02T14:46:05.5808366' AS DateTime2), 12, 4)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (19, N'Hamlet', N'hamilet75@gmail.com', N'Web', N'IT - 2 hisseye bolunur : hardware ve software', CAST(N'2022-01-02T15:39:03.8649062' AS DateTime2), 11, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [BlogId], [ParentCommentId]) VALUES (20, N'Shahin', N'shahin@gmail.com', N'Web', N'Hamlet duz deyir. Software ozu de 4 yere bolunur. Desktop , Web Development, Mobile Development, Embed (Machine Learning)', CAST(N'2022-01-02T15:41:29.3151348' AS DateTime2), 11, 19)
SET IDENTITY_INSERT [dbo].[BlogComments] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Name]) VALUES (1, N'SWIMMING POOL')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (2, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (3, N'FREE PARKING')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (4, N'SWIMMINGPOOL OUTDOOR')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (5, N'FAMILY ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (6, N'NON SMOKING ROOMS')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [About], [Address], [Phone_1], [Phone_2], [Phone_3], [StartDate], [EndDate], [Location], [Location_Note], [CreatedDate], [Capacity], [Website]) VALUES (8, N'Financial Planning', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p><p>&nbsp;Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.</p>', N'Nesimi rayonu Haci Zeynalabdin Tagiyev kucesi', N'077-451-45-63', N'012-412-45-63', N'055-451-45-63', CAST(N'2021-10-22T08:00:00.0000000' AS DateTime2), CAST(N'2023-11-22T22:00:00.0000000' AS DateTime2), N'Nesimi rayonu Haci Zeynalabdin Tagiyev kucesi', N'Nesimi rayonu Haci Zeynalabdin Tagiyev kucesi', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 5, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [About], [Address], [Phone_1], [Phone_2], [Phone_3], [StartDate], [EndDate], [Location], [Location_Note], [CreatedDate], [Capacity], [Website]) VALUES (12, N'Startup Investment', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p><p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.</p>', N'Nizami rayonu  8 Noyabr prospekti Mirze Elekber Sabir kucesi ', N'055-366-11-01', N'012-432-11-01', N'051-366-11-01', CAST(N'2021-01-12T08:00:00.0000000' AS DateTime2), CAST(N'2030-01-28T22:00:00.0000000' AS DateTime2), N'Nizami rayonu  8 Noyabr prospekti Mirze Elekber Sabir kucesi ', N'Nizami rayonu  8 Noyabr prospekti Mirze Elekber Sabir kucesi ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 35, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [About], [Address], [Phone_1], [Phone_2], [Phone_3], [StartDate], [EndDate], [Location], [Location_Note], [CreatedDate], [Capacity], [Website]) VALUES (13, N'Hamlet', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p><p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.</p>', N'Azadliq propekti Celil Memmedquluzade kucesi ', N'055-546-21-41', N'012-431-59-00', N'070-546-21-41', CAST(N'2021-10-22T08:00:00.0000000' AS DateTime2), CAST(N'2028-10-25T22:00:00.0000000' AS DateTime2), N'Azadliq propekti Celil Memmedquluzade kucesi ', N'Azadliq propekti Celil Memmedquluzade kucesi ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 15, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [About], [Address], [Phone_1], [Phone_2], [Phone_3], [StartDate], [EndDate], [Location], [Location_Note], [CreatedDate], [Capacity], [Website]) VALUES (18, N'Creative Invention', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p><p>&nbsp;</p><p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.</p>', N'Bineqedi rayonu Resulzade qesebesi Savalan kucesi ', N'055-426-41-01', N'012-486-41-01', N'077-426-41-01', CAST(N'2021-10-22T08:00:00.0000000' AS DateTime2), CAST(N'2030-01-22T22:00:00.0000000' AS DateTime2), N'Bineqedi rayonu Resulzade qesebesi Savalan kucesi ', N'Bineqedi rayonu Resulzade qesebesi Savalan kucesi ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 25, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [About], [Address], [Phone_1], [Phone_2], [Phone_3], [StartDate], [EndDate], [Location], [Location_Note], [CreatedDate], [Capacity], [Website]) VALUES (19, N'Code Academy', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!</p><p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.</p>', N'Nizami rayonu Qarayev qesebesi Savalan kucesi ', N'055-366-11-01', N'012-366-11-01', N'077-366-11-01', CAST(N'2021-10-22T08:00:00.0000000' AS DateTime2), CAST(N'2030-10-22T11:00:00.0000000' AS DateTime2), N'Nizami rayonu Qarayev qesebesi Savalan kucesi ', N'Nizami rayonu Qarayev qesebesi Savalan kucesi ', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 15, N'http://example.com')
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[FeaturesToRestaurants] ON 

INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (46, 3, 8)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (47, 2, 8)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (48, 5, 8)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (49, 5, 19)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (50, 3, 19)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (51, 1, 19)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (60, 3, 18)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (61, 1, 18)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (62, 6, 18)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (63, 5, 12)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (64, 4, 12)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (65, 2, 13)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (66, 1, 13)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (67, 3, 13)
INSERT [dbo].[FeaturesToRestaurants] ([Id], [FeaturesId], [RestaurantId]) VALUES (68, 4, 13)
SET IDENTITY_INSERT [dbo].[FeaturesToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name]) VALUES (1, N'Classic Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (2, N'Cheddar Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (3, N'Veggie Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (4, N'Chicken Burger')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] ON 

INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (5, 1, 13, 6.0000, N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (6, 1, 8, 6.0000, N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (7, 2, 8, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (8, 3, 8, 6.0000, N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (9, 4, 8, 6.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (10, 1, 18, 6.0000, N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (11, 2, 18, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (12, 3, 18, 6.0000, N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (13, 4, 18, 6.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (14, 1, 19, 6.0000, N' Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (15, 2, 19, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (16, 3, 19, 6.0000, N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (17, 4, 19, 6.0000, N' Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (18, 1, 12, 6.0000, N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (19, 2, 12, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (20, 3, 12, 6.0000, N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (21, 4, 12, 6.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (22, 2, 13, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (23, 3, 13, 6.0000, N'Panko crumbed and fried, grilled peppers and mushroom')
INSERT [dbo].[MenuToRestaurants] ([Id], [MenuId], [RestaurantId], [Price], [Description]) VALUES (24, 4, 13, 6.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([Id], [Image], [Name], [Email], [RestaurantId], [Phone]) VALUES (1, N'91e66f8f-f781-46b6-b405-2bdcffd463d5-202112311327SS-thumb-1.jpg', N'Victoria Benson', N'victoria@victoria.com', 12, N'(123) 123-456')
INSERT [dbo].[Administrators] ([Id], [Image], [Name], [Email], [RestaurantId], [Phone]) VALUES (3, N'1446feee-bde9-48e0-8f24-8fa47cff87b9-202201022353SS-thumb-3.jpg', N'Zerife Babayeva', N'zerife@gmail.comm', 8, N'055-321-21-21')
INSERT [dbo].[Administrators] ([Id], [Image], [Name], [Email], [RestaurantId], [Phone]) VALUES (4, N'ce033ef0-23f0-4bba-aaf5-a1dc774459a8-202201022354SS-thumb-2.jpg', N'Nigar Eliyev', N'nigar@gmail.com', 13, N'077-432-45-67')
INSERT [dbo].[Administrators] ([Id], [Image], [Name], [Email], [RestaurantId], [Phone]) VALUES (5, N'2102d563-2587-45ff-b9fd-4e3d3e0b999a-202201022355SS-thumb-4.jpg', N'Hamlet Haciyev', N'hamlet@gmail.com', 18, N'055-366-11-01')
INSERT [dbo].[Administrators] ([Id], [Image], [Name], [Email], [RestaurantId], [Phone]) VALUES (6, N'96a3c506-19ab-471d-867f-2ff730ffd0f5-202201022356SS-thumb-2.jpg', N'Sebine Elizade', N'sebine@gmail.com', 19, N'051-587-45-32')
SET IDENTITY_INSERT [dbo].[Administrators] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantComments] ON 

INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (5, N'Hamlet', N'hamilet75@gmail.com', N'Restoran', N'I liked Dolma', CAST(N'2022-01-02T22:11:21.6660933' AS DateTime2), 13)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (7, N'Shahin', N'shahin@gmail.com', N'Restoran', N'I liked Kebab', CAST(N'2022-01-02T22:16:29.4217272' AS DateTime2), 13)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (11, N'asd', N'shahin@gmail.com', N'asd', N'asd', CAST(N'2022-01-02T22:58:15.1776115' AS DateTime2), 12)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (12, N'Hamlet', N'hamilet75@gmail.com', N'asd', N'asd', CAST(N'2022-01-02T23:02:38.9035560' AS DateTime2), 12)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (13, N'Hamlet', N'hamilet75@gmail.com', N'asd', N'asd', CAST(N'2022-01-02T23:05:04.5683803' AS DateTime2), 18)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Text], [CreatedDate], [RestaurantId]) VALUES (14, N'Hamlet', N'hamilet75@gmail.com', N'Restoran', N'asd', CAST(N'2022-01-02T23:16:25.1195132' AS DateTime2), 12)
SET IDENTITY_INSERT [dbo].[RestaurantComments] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantImages] ON 

INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (23, N'4c5bc136-c561-4694-a23f-fc18991db700-202112252317SS-about-image.jpg', 8)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (24, N'd669b23a-9374-4133-a2e6-9ed3dc4f15b6-202112252317SS-bw-1.jpg', 8)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (25, N'212c2576-0c6d-44f1-919e-7a463a9aaaa9-202112252317SS-bw-2.jpg', 8)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (26, N'3e7163e3-5081-43fe-b4aa-f868235e4588-202112252317SS-bw-3.jpg', 8)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (67, N'65affce8-4892-48cf-8c63-9a067d4e5806-202112281638SS-dp-2.jpg', 19)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (68, N'7b38ba64-f741-4b49-b5b6-e17dbd457b0c-202112281638SS-dp-3.jpg', 19)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (69, N'fa4fd4e4-cfbd-4180-a455-3af983a2b733-202112281638SS-dp-4.jpg', 19)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (70, N'97cf310a-d504-4dd3-826c-87a679688d47-202112281638SS-dp-5.jpg', 19)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (71, N'93b1a43e-ae84-4c3f-9af0-8991ee6489c6-202201021613SS-most-img-1.jpg', 12)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (72, N'593a24f5-3642-4f71-9125-cc920ff9d219-202201021613SS-most-img-2.jpg', 13)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (73, N'266f84c5-df57-4be7-9238-91d89a4de1fb-202201021615SS-most-img-4.jpg', 18)
SET IDENTITY_INSERT [dbo].[RestaurantImages] OFF
GO
SET IDENTITY_INSERT [dbo].[RestBooks] ON 

INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (1, N'Hamlet Haciyev', CAST(N'2021-12-31T00:00:00.0000000' AS DateTime2), 4, N'Aze12712730', 12)
INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (2, N'Hamlet Haciyev', CAST(N'2021-12-31T00:00:00.0000000' AS DateTime2), 1, N'Aze12712730', 12)
INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (4, N'Hamlet Haciyev', CAST(N'2022-01-01T00:00:00.0000000' AS DateTime2), 2, N'Aze12712730', 13)
INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (5, N'Hamlet Haciyev', CAST(N'2022-01-25T16:45:00.0000000' AS DateTime2), 1, N'Aze12712730', 12)
INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (6, N'Hamlet Haciyev', CAST(N'2022-01-25T17:47:00.0000000' AS DateTime2), 1, N'Aze12712730', 8)
INSERT [dbo].[RestBooks] ([Id], [FullName], [Reserve_Date], [Person_Count], [Series_Number], [RestaurantId]) VALUES (7, N'Hamlet Haciyev', CAST(N'2022-01-25T18:50:00.0000000' AS DateTime2), 1, N'Aze12712730', 8)
SET IDENTITY_INSERT [dbo].[RestBooks] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'DINNER')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'HOTEL')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'SEA FOOD')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToRestaurants] ON 

INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (47, 2, 8)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (48, 3, 8)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (49, 1, 19)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (50, 2, 19)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (51, 3, 19)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (58, 1, 18)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (59, 3, 18)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (60, 2, 12)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (61, 3, 12)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (62, 1, 13)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (63, 3, 13)
SET IDENTITY_INSERT [dbo].[TagToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Title], [Image], [Content], [Description]) VALUES (1, N'Our Goal', N'3f27333e-b353-4487-9fba-e5f1b2e969a7-202112302109SS-about-image.jpg', N'Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel consectetur, ipsa autem vitae quos ea laborum expedita', N'<h3><strong>About Us</strong></h3><p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem sapiente, fugiat commodi reprehenderit expedita nam nemo</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p>')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [Image], [Page]) VALUES (1, N'About us', N'title-bar.jpg', N'About')
INSERT [dbo].[Banners] ([Id], [Title], [Image], [Page]) VALUES (2, N'Blog', N'title-bar.jpg', N'Blog')
INSERT [dbo].[Banners] ([Id], [Title], [Image], [Page]) VALUES (3, N'Contact us', N'title-bar.jpg', N'Contact')
INSERT [dbo].[Banners] ([Id], [Title], [Image], [Page]) VALUES (4, N'Listings', N'title-bar.jpg', N'Listing')
INSERT [dbo].[Banners] ([Id], [Title], [Image], [Page]) VALUES (5, N'Blog Detail', N'title.bar.jpg', N'Blog Detail')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (1, N'Hamlet', N'Haciyev', N'hamilet75@gmail.com', N'Web Development', N'Backend Layihesi', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (2, N'Hamlet', N'Haciyev', N'hamilet76@gmail.com', N'Web Development', N'asdasdasd', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (3, N'Hamlet', N'Haciyev', N'hamilet75@gmail.com', N'Web Development', N'hsbdjkfkjlabskjfbaklsvfavhksfvkhasvfhkasvfkhas', CAST(N'2021-12-25T14:26:09.4228122' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (4, N'Hamlet', N'Haciyev', N'hamilet76@gmail.com', N'Web', N'ahsdvasdlavsda', CAST(N'2021-12-28T12:32:37.4242666' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [Addresss], [Phone], [Email], [About], [Addresss_2], [Phone_2], [Email_2]) VALUES (1, N'logo-white.png', N'12345 Little Lonsdale St, Melbourne', N'(123) 123-456', N'office@example.com', N'Morbi convallis bibendum urna ut viverra. Maecenas quis consequat libero, a feugiat eros. Nunc ut lacinia tortor morbi ultricies laoreet ullamcorper phasellus semper.', N'423B, Road Wordwide Country, USA', N'+01-1234-567-8900', N'htinfotech7@gmail.com')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'Facebook', N'fab fa-facebook-f', N'https://www.facebook.com')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'Instagrams', N'fab fa-instagram', N'https://www.instagram.com')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'Twitter', N'fab fa-twitter', N'https://www.twitter.com')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (6, N'Github', N'fab fa-github', N'https://github.com/Hamlet-Haciyev?tab=repositories')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkingProcesses] ON 

INSERT [dbo].[WorkingProcesses] ([Id], [Icon], [Title], [Content]) VALUES (1, N'fas fa-bookmark', N'Plan', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
INSERT [dbo].[WorkingProcesses] ([Id], [Icon], [Title], [Content]) VALUES (2, N'fas fa-rocket', N'Code', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
INSERT [dbo].[WorkingProcesses] ([Id], [Icon], [Title], [Content]) VALUES (3, N'fas fa-check', N'Deliver', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
SET IDENTITY_INSERT [dbo].[WorkingProcesses] OFF
GO
SET IDENTITY_INSERT [dbo].[YourDreams] ON 

INSERT [dbo].[YourDreams] ([Id], [Icon], [Title], [Content]) VALUES (1, N'fa fa-search', N'Find Interesting Place', N'Proin dapibus nisl ornare diam varius tempus. Aenean a quam luctus, finibus tellus ut, convallis eros sollicitudin turpis.')
INSERT [dbo].[YourDreams] ([Id], [Icon], [Title], [Content]) VALUES (2, N'fas fa-phone-square', N'Contact a Few Owners', N'Maecenas pulvinar, risus in facilisis dignissim, quam nisi hendrerit nulla, id vestibulum metus nullam viverra porta purus.')
INSERT [dbo].[YourDreams] ([Id], [Icon], [Title], [Content]) VALUES (3, N'fas fa-user-plus', N'Make a Reservation', N'Faucibus ante, in porttitor tellus blandit et. Phasellus tincidunt metus lectus sollicitudin feugiat pharetra consectetur.')
SET IDENTITY_INSERT [dbo].[YourDreams] OFF
GO
