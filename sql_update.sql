USE [master]
GO
/****** Object:  Database [col_data]    Script Date: 27.03.2021 21:05:36 ******/
CREATE DATABASE [col_data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'col_data', FILENAME = N'D:\sql_data\col_data.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'col_data_log', FILENAME = N'D:\sql_data\col_data_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [col_data] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [col_data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [col_data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [col_data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [col_data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [col_data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [col_data] SET ARITHABORT OFF 
GO
ALTER DATABASE [col_data] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [col_data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [col_data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [col_data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [col_data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [col_data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [col_data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [col_data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [col_data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [col_data] SET  DISABLE_BROKER 
GO
ALTER DATABASE [col_data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [col_data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [col_data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [col_data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [col_data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [col_data] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [col_data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [col_data] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [col_data] SET  MULTI_USER 
GO
ALTER DATABASE [col_data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [col_data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [col_data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [col_data] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [col_data] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [col_data] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [col_data] SET QUERY_STORE = OFF
GO
USE [col_data]
GO
/****** Object:  User [win_service]    Script Date: 27.03.2021 21:05:36 ******/
CREATE USER [win_service] FOR LOGIN [win_service] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [win_service]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [win_service]
GO
/****** Object:  Table [dbo].[artykul]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[artykul](
	[ar_id] [int] IDENTITY(1,1) NOT NULL,
	[ar_nazwa] [nvarchar](max) NULL,
	[ar_liczba] [int] NULL,
	[ar_cena_netto] [decimal](18, 2) NULL,
	[ar_cena_brutto] [decimal](18, 2) NULL,
	[ar_aud_data] [datetime] NULL,
	[ar_aud_login] [nvarchar](max) NULL,
 CONSTRAINT [artykul_id] PRIMARY KEY CLUSTERED 
(
	[ar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dokument_artykul]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dokument_artykul](
	[nar_id] [int] IDENTITY(1,1) NOT NULL,
	[nar_ar_id] [int] NOT NULL,
	[nar_do_id] [int] NOT NULL,
	[nar_aud_data] [datetime] NULL,
	[nar_aud_login] [nvarchar](max) NULL,
 CONSTRAINT [naglowek_artykul_id] PRIMARY KEY CLUSTERED 
(
	[nar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dokument_naglowek]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dokument_naglowek](
	[do_id] [int] IDENTITY(1,1) NOT NULL,
	[do_nazwa] [nvarchar](max) NULL,
	[do_data] [datetime] NULL,
	[do_numer_klienta] [nvarchar](max) NULL,
	[do_cena_netto] [decimal](18, 2) NULL,
	[do_cena_brutto] [decimal](18, 2) NULL,
	[do_aud_data] [datetime] NULL,
	[do_aud_login] [nvarchar](max) NULL,
 CONSTRAINT [dokument_nagl_id] PRIMARY KEY CLUSTERED 
(
	[do_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [nvarchar](255) NOT NULL,
	[Level] [nvarchar](50) NOT NULL,
	[Logger] [nvarchar](255) NOT NULL,
	[Message] [nvarchar](4000) NOT NULL,
	[Exception] [nvarchar](2000) NULL,
	[aud_login] [nvarchar](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[artykul] ADD  CONSTRAINT [df_artykul__aud_data]  DEFAULT (getdate()) FOR [ar_aud_data]
GO
ALTER TABLE [dbo].[artykul] ADD  CONSTRAINT [df_artykul__aud_login]  DEFAULT (suser_name()) FOR [ar_aud_login]
GO
ALTER TABLE [dbo].[dokument_artykul] ADD  CONSTRAINT [df_nartykul__aud_data]  DEFAULT (getdate()) FOR [nar_aud_data]
GO
ALTER TABLE [dbo].[dokument_artykul] ADD  CONSTRAINT [df_nartykul__aud_login]  DEFAULT (suser_name()) FOR [nar_aud_login]
GO
ALTER TABLE [dbo].[dokument_naglowek] ADD  CONSTRAINT [df_dokument_nag__aud_data]  DEFAULT (getdate()) FOR [do_aud_data]
GO
ALTER TABLE [dbo].[dokument_naglowek] ADD  CONSTRAINT [df_dokument_nag__aud_login]  DEFAULT (suser_name()) FOR [do_aud_login]
GO
ALTER TABLE [dbo].[Log] ADD  CONSTRAINT [df_log__aud_login]  DEFAULT (suser_name()) FOR [aud_login]
GO
ALTER TABLE [dbo].[dokument_artykul]  WITH CHECK ADD  CONSTRAINT [FK_nagl_art_artykul] FOREIGN KEY([nar_ar_id])
REFERENCES [dbo].[artykul] ([ar_id])
GO
ALTER TABLE [dbo].[dokument_artykul] CHECK CONSTRAINT [FK_nagl_art_artykul]
GO
ALTER TABLE [dbo].[dokument_artykul]  WITH CHECK ADD  CONSTRAINT [FK_nagl_art_dokument] FOREIGN KEY([nar_do_id])
REFERENCES [dbo].[dokument_naglowek] ([do_id])
GO
ALTER TABLE [dbo].[dokument_artykul] CHECK CONSTRAINT [FK_nagl_art_dokument]
GO
/****** Object:  StoredProcedure [dbo].[p_int_artkul_dodaj]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[p_int_artkul_dodaj]
(
	@p_ar_nazwa nvarchar(max),
	@p_ar_liczba int,
	@p_ar_cena_br dec(18,2),
	@p_ar_cena_nt dec(18,2),
	@p_do_id int
)
AS
BEGIN
	SET NOCOUNT ON;

	declare
		@ar_id int

	insert into artykul(ar_cena_brutto,ar_cena_netto,ar_liczba,ar_nazwa)
	select @p_ar_cena_br,@p_ar_cena_nt,@p_ar_liczba,@p_ar_nazwa

	set @ar_id = SCOPE_IDENTITY()

	if isnull(@p_do_id,0) <> 0
	begin
		exec [p_int_dokument_artkul_dodaj] @ar_id,@p_do_id
	end
	
	exec p_int_artykul_pobierz null
	
END
GO
/****** Object:  StoredProcedure [dbo].[p_int_artkul_update]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[p_int_artkul_update]
(
	@p_ar_ids nvarchar(max),
	@p_ar_cena_brutto dec(18,2),
	@p_ar_cena_netto dec(18,2),
	@p_ar_liczba int,
	@p_ar_nazwa nvarchar(max),
	@p_ar_do_id int
)
AS
BEGIN
	
	SET NOCOUNT ON

	drop table if exists #a
	
	create table #a
	(
		ar_id_upd int
	)

	insert into #a
	select value
	from string_split(@p_ar_ids,',')
	
	update a
	set a.ar_cena_brutto = @p_ar_cena_brutto
		,a.ar_cena_netto = @p_ar_cena_netto
		,a.ar_liczba = @p_ar_liczba
		,a.ar_nazwa = @p_ar_nazwa
	from artykul a
	where exists
	(
		select top 1 1
		from #a f
		where f.ar_id_upd = a.ar_id
	)

	--usuwanie artykułu z dokumentu
	if isnull(@p_ar_do_id,0) > 0
	begin

		delete da
		from dokument_artykul da
		where exists
		(
			select top 1 1
			from #a f
			where f.ar_id_upd = da.nar_ar_id
		)

		insert into dokument_artykul(nar_ar_id,nar_do_id)
		select a.ar_id_upd,@p_ar_do_id
		from #a a

	end

	--usuwanie artykułu z dokumentu
	if isnull(@p_ar_do_id,0) = 0
	begin

		delete da
		from dokument_artykul da
		where exists
		(
			select top 1 1
			from #a f
			where f.ar_id_upd = da.nar_ar_id
		)

	end

	exec p_int_artykul_pobierz null

END
GO
/****** Object:  StoredProcedure [dbo].[p_int_artkul_usun]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[p_int_artkul_usun]
(
	@p_ar_ids nvarchar(max)
	,@p_model bit = null
)
AS
BEGIN
	
	SET NOCOUNT ON

	drop table if exists #a
	create table #a
	(
		ar_id_del int
	)

	insert into #a
	select value
	from string_split(@p_ar_ids,',')

	delete da
	from dokument_artykul da
	where exists
	(
		select top 1 1
		from #a f
		where f.ar_id_del = da.nar_ar_id
	)
		

	delete a
	from artykul a
	where exists
	(
		select top 1 1
		from #a f
		where f.ar_id_del = a.ar_id
	)
	
	--jak usuwam dokument, to uzywam tej procki i ona zwraca model dla atykulu ale w dokumencie i jest zle
	if @p_model is null
	begin

		exec p_int_artykul_pobierz null

	end

END
GO
/****** Object:  StoredProcedure [dbo].[p_int_artykul_pobierz]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[p_int_artykul_pobierz]
(
	@p_do_id int = null
)
--[p_int_artykul_pobierz] null
AS
BEGIN
	SET NOCOUNT ON

	select da.nar_do_id,a.ar_cena_brutto,a.ar_cena_netto,a.ar_id,a.ar_liczba,a.ar_nazwa
		,isnull(d.do_nazwa,'Brak dokumentu') as do_nazwa
	from artykul a
		left join dokument_artykul da on a.ar_id = da.nar_ar_id
		left join dokument_naglowek d on d.do_id = da.nar_do_id
	where ( da.nar_do_id = @p_do_id or @p_do_id is null)
END
GO
/****** Object:  StoredProcedure [dbo].[p_int_dokument_artkul_dodaj]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[p_int_dokument_artkul_dodaj]
(
	@p_ar_ids nvarchar(max),
	@p_do_id int
)
AS
BEGIN
	SET NOCOUNT ON;

	insert into dokument_artykul(nar_ar_id,nar_do_id)
	select x.value,@p_do_id
	from string_split(@p_ar_ids,',') x

END
GO
/****** Object:  StoredProcedure [dbo].[p_int_dokument_dodaj]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[p_int_dokument_dodaj]
(
	@p_do_nazwa nvarchar(max),
	@p_do_data datetime,
	@p_do_numer_kl nvarchar(max),
	@p_do_cena_br dec(18,2),
	@p_do_cena_nt dec(18,2)
)
AS
BEGIN
	SET NOCOUNT ON;

	insert into dokument_naglowek(do_cena_brutto,do_cena_netto,do_data,do_nazwa,do_numer_klienta)
	select @p_do_cena_br,@p_do_cena_nt,@p_do_data,@p_do_nazwa,@p_do_numer_kl

	exec p_int_dokument_pobierz null

END
GO
/****** Object:  StoredProcedure [dbo].[p_int_dokument_pobierz]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[p_int_dokument_pobierz]
(
	@p_do_id int = null
)
--p_int_dokument_pobierz 1
AS
BEGIN
	SET NOCOUNT ON

	select d.do_id,d.do_nazwa,d.do_numer_klienta,d.do_cena_brutto,d.do_cena_netto,d.do_data
	from dokument_naglowek d
	where (d.do_id = @p_do_id or @p_do_id is null)
END
GO
/****** Object:  StoredProcedure [dbo].[p_int_dokument_update]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[p_int_dokument_update]
(
	@p_do_ids nvarchar(max),
	@p_do_cen_br dec(18,2),
	@p_do_cen_nt dec(18,2),
	@p_do_nazwa nvarchar(max),
	@p_do_nr_kli nvarchar(max),
	@p_do_data datetime
)
AS
BEGIN
	
	SET NOCOUNT ON

	drop table if exists #a
	
	create table #a
	(
		do_id_upd int
	)

	insert into #a
	select value
	from string_split(@p_do_ids,',')
	
	update d
	set do_nazwa = @p_do_nazwa
		,do_data = @p_do_data
		,do_numer_klienta = @p_do_nr_kli
		,do_cena_brutto = @p_do_cen_br
		,do_cena_netto = @p_do_cen_nt
	from dokument_naglowek d
	where exists
	(
		select top 1 1
		from #a a
		where a.do_id_upd = d.do_id
	)
	
	exec [p_int_dokument_pobierz] null
END
GO
/****** Object:  StoredProcedure [dbo].[p_int_dokument_usun]    Script Date: 27.03.2021 21:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[p_int_dokument_usun]
(
	@p_do_ids nvarchar(max)
)
AS
BEGIN
	
	SET NOCOUNT ON

	declare
		@ar_ids_del nvarchar(max)

	drop table if exists #d
	
	create table #d
	(
		do_id_del int
	)

	insert into #d
	select value
	from string_split(@p_do_ids,',')

	set @ar_ids_del =
	(
		stuff
		(
			(
				select ',' + cast(da.nar_ar_id as nvarchar(max))
				from dokument_artykul da
				where exists
				(
					select top 1 1
					from #d d
					where d.do_id_del = da.nar_do_id
				)
				for xml path('')
			),1,1,''
		)
	)

	exec [p_int_artkul_usun] @ar_ids_del, 1

	delete da
	from dokument_artykul da
	where exists
	(
		select top 1 1
		from #d d
		where d.do_id_del = da.nar_do_id
	)

	delete dn
	from dokument_naglowek dn
	where exists
	(
		select top 1 1
		from #d d
		where d.do_id_del = dn.do_id
	)

	exec [p_int_dokument_pobierz] null

END
GO
USE [master]
GO
ALTER DATABASE [col_data] SET  READ_WRITE 
GO
