USE [Healthcareplus]
GO
/****** Object:  Table [dbo].[Appointment_Charges]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Charges](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](150) NOT NULL,
	[amount] [float] NOT NULL,
	[appointment_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Appointment_Charges] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[appt_number] [int] NOT NULL,
	[payment_status] [varchar](10) NOT NULL,
	[schedule_id] [bigint] NOT NULL,
	[patient_id] [bigint] NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Appoinments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorProfiles]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorProfiles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[qualification] [varchar](50) NOT NULL,
	[specialization] [varchar](100) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[location] [varchar](20) NOT NULL,
	[home_address] [varchar](150) NOT NULL,
	[hospital_address] [varchar](150) NOT NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_DoctorProfiles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[disease] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[payment_method] [varchar](50) NOT NULL,
	[total] [float] NOT NULL,
	[balance] [float] NULL,
	[status] [varchar](10) NOT NULL,
	[transaction_id] [varchar](150) NULL,
	[appointment_id] [bigint] NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[doctor_id] [bigint] NOT NULL,
	[location] [varchar](50) NOT NULL,
	[room] [tinyint] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[updated_at] [timestamp] NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffProfiles]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffProfiles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_StaffProfile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.06.2024 23:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointment_Charges] ON 

INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (1, N'123123', 11111, 1)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (2, N'2323', 111, 2)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (3, N'300', 3300, 3)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (4, N'300', 600, 4)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (5, N'300', 800, 5)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (6, N'300', 33, 6)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (7, N'22', 22, 6)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (8, N'33', 22, 6)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (9, N'23', 23, 7)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (10, N'23', 23, 7)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (11, N'300', 300, 8)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (12, N'300', 3000, 9)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (13, N'20', 200, 10)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (14, N'300', 300, 11)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (15, N'6666', 6666, 12)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (16, N'600', 300, 13)
INSERT [dbo].[Appointment_Charges] ([id], [title], [amount], [appointment_id]) VALUES (17, N'700', 300, 14)
SET IDENTITY_INSERT [dbo].[Appointment_Charges] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (1, 1, N'paid', 1, 1, CAST(N'2024-06-08T02:10:07.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (2, 1, N'paid', 2, 2, CAST(N'2024-06-08T02:44:37.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (3, 1, N'paid', 5, 1, CAST(N'2024-06-08T03:17:26.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (4, 2, N'unpaid', 2, 2, CAST(N'2024-06-12T23:56:52.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (5, 3, N'paid', 2, 2, CAST(N'2024-06-13T01:33:15.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (6, 4, N'unpaid', 2, 1, CAST(N'2024-06-20T16:25:01.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (7, 2, N'paid', 1, 2, CAST(N'2024-06-20T16:25:20.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (8, 1, N'paid', 7, 1, CAST(N'2024-06-20T16:29:22.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (9, 5, N'unpaid', 2, 2, CAST(N'2024-06-20T16:48:54.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (10, 6, N'unpaid', 2, 2, CAST(N'2024-06-20T16:50:11.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (11, 7, N'unpaid', 2, 2, CAST(N'2024-06-20T17:02:05.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (12, 8, N'unpaid', 2, 2, CAST(N'2024-06-20T17:03:19.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (13, 1, N'paid', 8, 4, CAST(N'2024-06-23T23:10:34.000' AS DateTime))
INSERT [dbo].[Appointments] ([id], [appt_number], [payment_status], [schedule_id], [patient_id], [created_at]) VALUES (14, 1, N'paid', 6, 1, CAST(N'2024-06-23T23:27:13.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[DoctorProfiles] ON 

INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (1, N'Вторая', N'Психиатр', N'7982616233', N'пр. Косиора, 46', N'asdasd', N'asdasd', 2)
INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (18, N'Высшая', N'Кардиолог', N'8974029232', N'пл. Чехова, 28', N'Арцеуловская аллея ', N'Большакова', 34)
INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (23, N'Вторая', N'Семейная медицина', N'1231231223', N'пр. Косиора, 46', N'asdssdsd', N'123dasda', 39)
INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (24, N'Вторая', N'Уролог', N'1231231233', N'пр. Косиора, 46', N'SDFSDF', N'asdASD', 40)
INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (26, N'Вторая', N'Уролог', N'9046798673', N'пр. Косиора, 46', N'Королева 10', N'Королева 9', 42)
INSERT [dbo].[DoctorProfiles] ([id], [qualification], [specialization], [contact_no], [location], [home_address], [hospital_address], [user_id]) VALUES (29, N'Вторая', N'Уролог', N'9876722190', N'пр. Косиора, 46', N'Залупкино 2', N'Королевкая 10', 52)
SET IDENTITY_INSERT [dbo].[DoctorProfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([id], [first_name], [last_name], [email], [contact_no], [address], [disease]) VALUES (1, N'Леся', N'Кокарев', N'kokarev@mail.ru', N'7972617222', N'Советская 78', N'Приступы эпилепсии')
INSERT [dbo].[Patients] ([id], [first_name], [last_name], [email], [contact_no], [address], [disease]) VALUES (2, N'Роман', N'Кокарев', N'kokarev@mail.ru', N'7927323232', N'Совесткая 19', N'Психически нестабилен')
INSERT [dbo].[Patients] ([id], [first_name], [last_name], [email], [contact_no], [address], [disease]) VALUES (3, N'Вовва', N'Вова', N'vova@mail.ru', N'9022376897', N'Вова 29', N'Болит живот')
INSERT [dbo].[Patients] ([id], [first_name], [last_name], [email], [contact_no], [address], [disease]) VALUES (4, N'Алексей', N'Поносенков', N'alex@mail.ru', N'9862577159', N'Псковская 58', N'Аутизм')
INSERT [dbo].[Patients] ([id], [first_name], [last_name], [email], [contact_no], [address], [disease]) VALUES (5, N'Андрей', N'Морель', N'andrey@mail.ru', N'9875088150', N'Морель 78', N'Болит рука')
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (1, N'card', 11111, 0, N'pending', N'null', 1, CAST(N'2024-06-08T02:10:31.060' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (2, N'cash', 111, 0, N'pending', N'null', 2, CAST(N'2024-06-08T02:44:44.787' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (3, N'card', 3300, 0, N'pending', N'null', 3, CAST(N'2024-06-08T03:18:01.170' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (4, N'cash', 800, 200, N'pending', N'null', 5, CAST(N'2024-06-13T01:33:22.057' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (5, N'cash', 46, 454, N'pending', N'null', 7, CAST(N'2024-06-20T16:25:40.533' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (6, N'cash', 300, 100, N'pending', N'null', 8, CAST(N'2024-06-20T16:29:29.007' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (7, N'card', 300, 700, N'pending', N'null', 13, CAST(N'2024-06-23T23:11:48.133' AS DateTime))
INSERT [dbo].[Payments] ([id], [payment_method], [total], [balance], [status], [transaction_id], [appointment_id], [created_at]) VALUES (8, N'cash', 300, 700, N'pending', N'null', 14, CAST(N'2024-06-23T23:27:17.523' AS DateTime))
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (1, 2, N'Kandy', 1, CAST(N'2024-06-10T02:08:51.000' AS DateTime), CAST(N'2024-06-20T02:08:51.000' AS DateTime))
INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (2, 2, N'Kandy', 1, CAST(N'2024-06-10T02:38:53.000' AS DateTime), CAST(N'2024-06-29T02:38:53.000' AS DateTime))
INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (5, 34, N'пер. Гагарина, 06', 4, CAST(N'2024-06-12T03:16:17.000' AS DateTime), CAST(N'2024-06-28T03:16:17.000' AS DateTime))
INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (6, 42, N'спуск Славы, 29', 5, CAST(N'2024-06-27T01:34:14.000' AS DateTime), CAST(N'2024-06-29T01:34:14.000' AS DateTime))
INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (7, 34, N'спуск Домодедовская, 82', 6, CAST(N'2024-06-25T16:28:28.000' AS DateTime), CAST(N'2024-06-29T16:28:28.000' AS DateTime))
INSERT [dbo].[Schedules] ([id], [doctor_id], [location], [room], [start_date], [end_date]) VALUES (8, 52, N'пер. Гагарина, 06', 4, CAST(N'2024-06-24T23:08:58.000' AS DateTime), CAST(N'2024-06-28T23:08:58.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
SET IDENTITY_INSERT [dbo].[StaffProfiles] ON 

INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (1, N'7981708815', N'Туристская 19', 13)
INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (12, N'7982316231', N'Туристская 18', 24)
INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (13, N'9058776542', N'Королева 20', 45)
INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (14, N'7687876565', N'Лорах 67', 48)
INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (15, N'9876546272', N'Туристская 22', 49)
INSERT [dbo].[StaffProfiles] ([id], [contact_no], [address], [user_id]) VALUES (16, N'9854077150', N'Арцеулловская 18', 53)
SET IDENTITY_INSERT [dbo].[StaffProfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (1, N'admin', N'system', N'admin@healthcareplus.com', N'9F55A00DDFA94D7D27C80D9E56CBBD362AB8281C03E2ED5CD3B28AECAEAFCE00', N'admin')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (2, N'Орел', N'Олегович', N'orel@mail.ru', N'054E3B308708370EA029DC2EBD1646C498D59D7203C9E1A44CF0484DF98E581A', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (13, N'Леня', N'Андреевич', N'timur@mail.ru', N'D8A928B2043DB77E340B523547BF16CB4AA483F0645FE0A290ED1F20AAB76257', N'staff')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (24, N'Loher', N'Loh', N'loher@mail.ru', N'D5FE46B1204CB7BB339B929B1777E04D2C7235915D7A50D6BAA134E20DBC80C6', N'staff')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (34, N'Лебедев', N'Павел', N'lebedev@mail.ru', N'E81BC4DC3764291B81431AE52072E04720F7F5217F8CFB82F029418F240473CB', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (39, N'asdasdasd', N'asdasd', N'as@mail.ru', N'332D1EA7AFF29AEE36646C3C7292AB5F3C42C3B9AA1F0EA25B312A5C6B4AD808', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (40, N'asdasd', N'ASDASD', N'asd@mail.ru', N'894BC4FE63B60AAFCA0551268BCCAC4CC3C864E9D7A350687E0FD87A70CB2FA7', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (42, N'Володя', N'Володя', N'volodya@mail.ru', N'2E5EC44990A6C367EAB22C53B4571F6D75F78547BA96654CFD90BC1CC03F0647', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (45, N'Володя', N'Володя', N'valod@mail.ru', N'E079B5C8DA7C98AD0B93984550AA9CBE921D34D1A3D7E25D1410D9C74F5DAD83', N'admin')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (48, N'Лорах', N'Лорах', N'lorah@mail.ru', N'CDFCA5ABE3B9D60489B550F510556335C663EAEBEF140ECD3F39E34D63E63069', N'оператор')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (49, N'Тимур', N'Тимурович', N'timur.kriulenko.10@mail.ru', N'700A253839F12D367FE92E3DE075AA3CE5073602834297CDEAA35DA7E2559AEE', N'staff')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (52, N'Илья', N'Кококрев', N'ilya@mail.ru', N'4D1F24979B5675E0BD0310F026218BD6308A7A7F3E0E7A6AEFB6C813961C2875', N'doctor')
INSERT [dbo].[Users] ([id], [first_name], [last_name], [email], [password], [role]) VALUES (53, N'Юлия', N'Романова', N'uliya@mail.ru', N'8829BCC49E530DBCF3EC9A918D60F13BE5CF7D41BD4D4241F4AD6D2E8F22C309', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CK_Contact_No]    Script Date: 23.06.2024 23:30:59 ******/
ALTER TABLE [dbo].[DoctorProfiles] ADD  CONSTRAINT [CK_Contact_No] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CK_Patients_ContactNo]    Script Date: 23.06.2024 23:30:59 ******/
ALTER TABLE [dbo].[Patients] ADD  CONSTRAINT [CK_Patients_ContactNo] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CK_StaffProfile_ContactNo]    Script Date: 23.06.2024 23:30:59 ******/
ALTER TABLE [dbo].[StaffProfiles] ADD  CONSTRAINT [CK_StaffProfile_ContactNo] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_Email]    Script Date: 23.06.2024 23:30:59 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [Unique_Email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF_Appoinments_payment_status]  DEFAULT ('unpaid') FOR [payment_status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_role]  DEFAULT ('patient') FOR [role]
GO
ALTER TABLE [dbo].[Appointment_Charges]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Charges_Appointments] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointments] ([id])
GO
ALTER TABLE [dbo].[Appointment_Charges] CHECK CONSTRAINT [FK_Appointment_Charges_Appointments]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appoinments_Patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patients] ([id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appoinments_Patients]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appoinments_Schedules] FOREIGN KEY([schedule_id])
REFERENCES [dbo].[Schedules] ([id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appoinments_Schedules]
GO
ALTER TABLE [dbo].[DoctorProfiles]  WITH CHECK ADD  CONSTRAINT [FK_DoctorProfiles_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[DoctorProfiles] CHECK CONSTRAINT [FK_DoctorProfiles_Users]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Appointments] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointments] ([id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Appointments]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Users] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Users]
GO
ALTER TABLE [dbo].[StaffProfiles]  WITH CHECK ADD  CONSTRAINT [FK_StaffProfile_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[StaffProfiles] CHECK CONSTRAINT [FK_StaffProfile_Users]
GO
