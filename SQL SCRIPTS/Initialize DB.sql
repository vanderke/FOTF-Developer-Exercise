--- BUILD TABLES
CREATE TABLE [dbo].[Content] (
    [ContentID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]     VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([ContentID] ASC)
);


CREATE TABLE [dbo].[ContentStories] (
    [ContentStoryID]   INT              IDENTITY (1, 1) NOT NULL,
    [ContentID]        INT              NOT NULL,
    [RelatedProductID] UNIQUEIDENTIFIER NULL,
    [StoryTitle]       VARCHAR (255)    NOT NULL,
    [StoryText]        VARCHAR (MAX)    NOT NULL,
    [ImagePath]        VARCHAR (255)    NULL,
    [displayOrder]     SMALLINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([ContentStoryID] ASC)
);

CREATE TABLE [dbo].[Images] (
    [ImageID]   INT           IDENTITY (1, 1) NOT NULL,
    [ImagePath] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([ImageID] ASC)
);

CREATE TABLE [dbo].[ProductDetails] (
    [ProductDetailID] INT              IDENTITY (1, 1) NOT NULL,
    [ProductID]       UNIQUEIDENTIFIER NOT NULL,
    [DetailTitle]     VARCHAR (300)    NOT NULL,
    [DetailSummary]   VARCHAR (300)    NOT NULL,
    [DisplayOrder]    SMALLINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductDetailID] ASC)
);

CREATE TABLE [dbo].[Products] (
    [ProductID]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [ISBN]        VARCHAR (12)     NOT NULL,
    [Title]       VARCHAR (200)    NOT NULL,
    [Summary]     VARCHAR (MAX)    NOT NULL,
    [Description] VARCHAR (MAX)    NOT NULL,
    [Price]       MONEY            NOT NULL,
    [QtyAvail]    SMALLINT         NOT NULL,
    [Authors]     VARCHAR (100)    NULL,
    [ImagePath]   VARCHAR (60)     NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);



----  INSERT DATA

INSERT INTO [dbo].[Products] ([ProductID], [ISBN], [Title], [Summary], [Description], [Price], [QtyAvail], [Authors], [ImagePath]) VALUES (N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'1624054064', N'Ready to Wed', N'Ready To Wed Book 12 Ways to Start a Marriage You''ll Love', N'Written for engaged couples, this book is full of tools, tips, and instructions that start a couple on a straight path to a strong marriage. Emphasizing that marriage and family are good, the book integrates the 12 Traits of a Thriving Marriage to help prepare and strengthen marriages from the start. A vital resource for those who mentor engaged couples and for pastors/churches who wish to use it in a premarital counseling program.', CAST(19.9900 AS Money), 22, N'Dr. Greg and Erin Smalley', N'/Content/Images/ready-to-wed.jpg')
INSERT INTO [dbo].[Products] ([ProductID], [ISBN], [Title], [Summary], [Description], [Price], [QtyAvail], [Authors], [ImagePath]) VALUES (N'8ffce162-f929-450c-b4fc-3a93c86f507f', N'12345', N'Ready To Wed Couples Workbook', N'Ready To Wed Couples Workbook - Time to do some homework!', N'As you progress through Ready to Wed™ kit with your pastor or mentor couple, this guide will help you and your future spouse work together to build the foundation for a marriage that will last a lifetime. For participation in the DVD series, you and your fiancé should have your own copy of the workbook.', CAST(29.9900 AS Money), 22, N'Dr. Greg and Erin Smalley', N'/Content/Images/couple-book-image.png')
INSERT INTO [dbo].[Products] ([ProductID], [ISBN], [Title], [Summary], [Description], [Price], [QtyAvail], [Authors], [ImagePath]) VALUES (N'8ad04013-355b-4d06-abfb-c0e144e1a8b4', N'235235', N'Ready To Wed Kit', N'Engaging DVD series, leader''s guide, two copies of the couple''s workbook.  You have it all here!', N'Ready to Wed™ Engaged Couples kit features an engaging 10-session DVD series, a leader’s guide, two copies of the couple’s workbook, and the humorous and insightful Ready to Wed book co-authored by Dr. Greg and Erin Smalley along with other marriage experts. From in-laws and finances, to intimacy and chores, Ready to Wed is the perfect pre-marital program to help a pastor or mentor couple prepare engaged couples for the joys and challenges of a lifetime marriage. Promotional materials for church program launch are also included on a resource disk.
', CAST(39.9900 AS Money), 22, N'Dr. Greg and Erin Smalley', N'/Content/Images/ready-to-wed-kit.png')



SET IDENTITY_INSERT [dbo].[Content] ON
INSERT INTO [dbo].[Content] ([ContentID], [Title]) VALUES (1, N'Home')
INSERT INTO [dbo].[Content] ([ContentID], [Title]) VALUES (2, N'About Ministry')
INSERT INTO [dbo].[Content] ([ContentID], [Title]) VALUES (3, N'Testimonial')
SET IDENTITY_INSERT [dbo].[Content] OFF

SET IDENTITY_INSERT [dbo].[ContentStories] ON
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (1, 1, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Are you Ready To Wed?', N'We can’t guarantee that Ready To Wed™ will take all the challenges out of your wedding or your marriage. It won’t keep you from forgetting your anniversary, thaw all the icy silences, or make your spouse alphabetize the shoes in your closet. But it will help you understand why you’re getting married, how to stay that way, and how to enjoy it to the fullest. That’s because you’ll learn what’s vital to a healthy relationship, keys to working out your differences, and what God considers most important in “holy matrimony.” So get started now, take the 4 keys steps that will impact the course of your marriage.', N'/Content/Images/couple-book-image.png', 0)
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (2, 2, N'8ad04013-355b-4d06-abfb-c0e144e1a8b4', N'Hands-on in helping other couples', N'Dr. Greg and Erin Smalley recently celebrated 24 years of marriage! They are the proud parents of three daughters—Taylor, Murphy, and Annie—and a son, Garrison. Together, they make their home in Colorado Springs, Colorado, as Greg is the Vice President of Family Ministries at Focus on the Family. In this role, Greg helps prepare individuals for marriage and parenthood, strengthen existing marriages and families, and provides support for couples and parents in crisis.

Prior to joining Focus, Greg and Erin worked for the Center for Relationship Enrichment at John Brown University, and Greg was the President of the National Institute of Marriage. He is the author of thirteen books, including The DNA of Relationships, The Wholehearted Marriage, Fight Your Way to a Better Marriage, and The Date Night Challenge.

After overcoming struggles early in their own marriage, Greg and Erin knew they wanted to be hands-on in helping other couples. Greg earned his doctorate at the Rosemead School of Psychology at Biola University and a counseling degree from Denver Seminary.

Together they have led marriage seminars around the world and trained pastors, professionals, and lay leaders about how to effectively work with married and engaged couples.', N'/Content/Images/smalley-image-about-page.png', 0)
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (3, 3, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Must Read', N'In Ready to Wed, Focus on the Family has put together a collection of authors sharing in vast details about what they have learned throughout their marriage. The main authors and editors are Dr. Greg and Erin Smalley. The other authors are Tedd Cunningham, Scott Stanley, Gary Smalley, Joe White, Juli Slattery, Joshua Straub, John Trent, Bill and Pam Farrel, Susan and Dale Mathis, Scott and Bethany Palmer, and Tim Popadic. The book is divided into two sections and each chapter is written by different authors.

Dr. Greg and Erin Smalley began the book by sharing how God described marriage in the Bible. God declared that it isn’t good for man to be alone. We are instructed that a man must leave his father and mother and be one flesh with his wife and cleave to his wife. They also revealed some of the top reason people get married. Some of these are: “to marry their soul mate, get their emotional needs met, raise kids and have a family, fulfill sexual needs and desires, financial security”, and much more. It’s critical that we marry for the precise reasons and build a solid marriage.

One of my favorite chapters was, “Honoring You All the Days of My Life” by Gary Smalley. This book discussed the power of honoring our spouse and how husbands are instructed to love their wife like himself and cherish her (Ephesians 5:33). I especially loved how Gary revealed that he wrote a list about everything he cherished about his wife and when he was frustrated or mad at his wife he would pull out his list to remind himself of everything he loved about his wife. He also included a helpful list to help readers begin their on cherished list. Another helpful benefit in this chapter was a nourished list that included a list from both genders explaining how they feel loved by their spouse.

I would recommend this life changing book to anyone who is engaged or married and they are seeking to build a solid marriage with Jesus at the center. I immensely liked how the book had so many different authors who are expects in their field and they have massive knowledge about marriage. Even though I’m single and not married, this book is one I will reread with my future spouse and I believe it will impact our marriage and help build it on a solid foundation with Jesus being at the center. I really enjoyed Bill and Pam Farrel chapters about expectation in marriage and this taught me that everyone has huge expectations when it comes to what their spouse is supposed to do for them. It has caused to wonder what my expectations are and how to not hold my future bride to a too high of a standard. If you’re looking for an excellent book about marriage, then read this one!
', N'/Content/Images/fotf_icon.jpg', 0)
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (4, 3, N'00000000-0000-0000-0000-000000000000', N'Changed my view of marriage', N'You’re engaged, and the checklist for the day of your dreams is a mile long. In the who, what, where, and how of planning, the why can be forgotten.
Ready to Wed provides chapter after chapter of wisdom and insight to provide a solid, Biblical base for marriages! Whether you are engaged, courting, dating, thinking about starting a relationship, or even single with no prospects in sight (such as myself), you will benefit greatly from the sound wisdom in this book! Likewise, married couples would do well to read this book together and analyze their marriage! With a compilation of thoughts from various Christian couples or individuals, Ready to Wed is truly a relationship-changing and thus life-changing book! Each chapter closes with discussion questions which will help you think through the lessons learned in each portion of the book. 
I whizzed through this book; it was so practical (even though I am not in a relationship!) and understandable. I highly recommend this book. Of course there are doctrinal differences which I noticed as I read it but can''t recall now. And I didn''t agree with all views the authors presented but for the most part this book was very helpful and I am looking forward to someday reading it with my own man!

', N'/Content/Images/couple-book-image.png', 0)
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (5, 3, N'8ffce162-f929-450c-b4fc-3a93c86f507f', N'Good for those already married too!', N'This is a very informative, educational book for couples. After reading through it myself, I now plan to share it with my children who are engaged and planning weddings. 

While it does have Biblical references and a Christian perspective, it is still beneficial for those who might not be coming at marriage from a religious perspective. It''s like having premarital counseling in the comfort of your own home. 

The book is divided into two sections: one on preparing for marriage, and one on conflict management. Each chapter is written by a different expert, so that you get a variety of perspectives. 

Even though the book is about starting a marriage, I found some tidbits that will be beneficial to my well-established marriage as well.', N'/Content/Images/rtw-kit-product.png', 0)
INSERT INTO [dbo].[ContentStories] ([ContentStoryID], [ContentID], [RelatedProductID], [StoryTitle], [StoryText], [ImagePath], [displayOrder]) VALUES (6, 1, N'00000000-0000-0000-0000-000000000000', N'Take the Couple Checkup', N'This is designed to give you a clear snapshot of your relationship highlighting both your strengths and growth areas. This valuable information will provide a basis for helpful discussions and opportunities for growth as you prepare for your upcoming marriage journey.', N'/Content/Images/ready-to-wed-kit.png', 0)
SET IDENTITY_INSERT [dbo].[ContentStories] OFF


SET IDENTITY_INSERT [dbo].[Images] ON
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (1, N'/Content/Images/fotf_icon.jpg')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (2, N'/Content/Images/ready-to-wed-kit.png')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (3, N'/Content/Images/ready-to-wed-mobile.png')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (4, N'/Content/Images/ready-to-wed.jpg')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (5, N'/Content/Images/couple-book-image.png')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (6, N'/Content/Images/rtw-kit-product.png')
INSERT INTO [dbo].[Images] ([ImageID], [ImagePath]) VALUES (7, N'/Content/Images/smalley-image-about-page.png')
SET IDENTITY_INSERT [dbo].[Images] OFF


SET IDENTITY_INSERT [dbo].[ProductDetails] ON
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (1, N'773908dd-55cf-45d6-b8e1-41244df60ee3', N'yrdy', N'yrdyrdy', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (2, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Life Long Commitment', N'Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (3, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Spending Enjoyable Time Together', N'In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (4, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Positive Communication', N'Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (5, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Shared Spiritual Intimacy', N'Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (6, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Healthy Individuals', N'A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (7, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Mutually Satisfying Physical Intimacy', N'Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (8, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Healthy Conflict Management', N'Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (9, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Shared Responsibility (Teamwork)', N'Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (10, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Coping With Change, Stress and Crises', N'You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (11, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Cherish', N'Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (12, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Nourish', N'Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her.', 0)
INSERT INTO [dbo].[ProductDetails] ([ProductDetailID], [ProductID], [DetailTitle], [DetailSummary], [DisplayOrder]) VALUES (13, N'59d7c905-5fbb-4750-80ef-38d17d6f15ea', N'Community-Mindedness', N'Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage.', 0)
SET IDENTITY_INSERT [dbo].[ProductDetails] OFF




