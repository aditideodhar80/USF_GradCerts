if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_gcapplicationprocess_gccertificatedetails]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[gcapplicationrequirements] DROP CONSTRAINT FK_gcapplicationprocess_gccertificatedetails
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_gccontacts_gccertificatedetails]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[gccontacts] DROP CONSTRAINT FK_gccontacts_gccertificatedetails
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_gccourses_gccertificatedetails]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[gccourses] DROP CONSTRAINT FK_gccourses_gccertificatedetails
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_checkcertavailablity]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_checkcertavailablity]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deleteadmissionrequirements]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deleteadmissionrequirements]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deleteapplicationrequirements]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deleteapplicationrequirements]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deletecertificate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deletecertificate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deletecontacts]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deletecontacts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deletecourses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deletecourses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_deleteprereqs]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_deleteprereqs]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_getdata]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_getdata]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_insertadmissionreq]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_insertadmissionreq]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_insertapplicationreq]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_insertapplicationreq]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_insertcontacts]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_insertcontacts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_insertcourses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_insertcourses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_insertprereqs]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_insertprereqs]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_inserttitledetails]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_inserttitledetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updatecertstatus]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updatecertstatus]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updateinsertadmissionreq]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updateinsertadmissionreq]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updateinsertapplicationreq]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updateinsertapplicationreq]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updateinsertcontacts]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updateinsertcontacts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updateinsertcourses]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updateinsertcourses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updateinsertprereqs]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updateinsertprereqs]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updatestatus]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updatestatus]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_gc_updatetitledetails]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_gc_updatetitledetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_get_certinfo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_get_certinfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[metro_logincheck]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[metro_logincheck]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gcadmissionrequirements]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gcadmissionrequirements]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gcapplicationrequirements]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gcapplicationrequirements]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gccertificatedetails]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gccertificatedetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gccontacts]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gccontacts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gccourses]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gccourses]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gcprequisites]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gcprequisites]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gcstatus]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gcstatus]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[gcusers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[gcusers]
GO

CREATE TABLE [dbo].[gcadmissionrequirements] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NULL ,
	[admissionreqdocuments] [varchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[i_order] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gcapplicationrequirements] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NOT NULL ,
	[applicationrequirements] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gccertificatedetails] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[certificatecode] [varchar] (4) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[certificatename] [varchar] (225) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[collegecode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[linkname] [varchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[certificatetitle] [varchar] (225) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[courselocation] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[briefdesc] [varchar] (5000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CEU] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[credittograd] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[transfercredit] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[standardtests] [varchar] (5000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[admissionreq] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[appprocess] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[prerequisiteinfo] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[registrationprocess] [varchar] (1500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[tuitionfees] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[financialaid] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[timelimit] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[deptwebsite] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[requiredcourseinfo] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[electivecourseinfo] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[certtype] [varchar] (3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[status] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gccontacts] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NULL ,
	[fname] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[lname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[phone] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[picturelink] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pict_type] [varchar] (225) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gccourses] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NOT NULL ,
	[coursetype] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[coursename] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gcprequisites] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NULL ,
	[prerequisites] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gcstatus] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[hcertificatedetails] [int] NULL ,
	[titlestatus] [int] NULL ,
	[adreqstatus] [int] NULL ,
	[appreqstatus] [int] NULL ,
	[contactstatus] [int] NULL ,
	[reqcoursestatus] [int] NULL ,
	[electivestatus] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[gcusers] (
	[hid] [int] IDENTITY (1, 1) NOT NULL ,
	[urnetid] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[ur_fname] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ur_lname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ur_role] [int] NOT NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_checkcertavailablity]

@p_certid INTEGER = NULL,
@p_certcode  VARCHAR(4) ,
@p_intCount INTEGER OUTPUT


AS

BEGIN

IF @p_certid = NULL 
	SELECT @p_intCount =  (SELECT COUNT(*) 
	FROM  [dbo].[gccertificatedetails]
	WHERE [certificatecode] = @p_certcode)

ELSE
	
	SELECT @p_intCount =  (select count(*) FROM  [dbo].[gccertificatedetails]
	where hid not in (select hid from  gccertificatedetails where hid = @p_certid)
	and [certificatecode] = @p_certcode)
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deleteadmissionrequirements]
	
@p_hid INTEGER

AS

	SET NOCOUNT ON

	DELETE FROM [dbo].[gcadmissionrequirements]
	WHERE hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deleteapplicationrequirements]
	
@p_hid INTEGER

AS

	SET NOCOUNT ON

	DELETE FROM [dbo].[gcapplicationrequirements]
	WHERE hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deletecertificate]
	
@p_certid INTEGER

AS

	SET NOCOUNT ON

	delete from dbo.gcprequisites where hcertificatedetails = @p_certid 
	delete from dbo.gcadmissionrequirements where hcertificatedetails = @p_certid
	delete from dbo.gcapplicationrequirements where hcertificatedetails = @p_certid
	delete from dbo.gccontacts where hcertificatedetails = @p_certid
	delete from dbo.gccourses where hcertificatedetails = @p_certid
	delete from dbo.gcstatus where hcertificatedetails = @p_certid
	delete from dbo.gccourses where hcertificatedetails = @p_certid
	delete from dbo.gccertificatedetails where hid = @p_certid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deletecontacts]
	
@p_hid INTEGER

AS

	SET NOCOUNT ON

	DELETE FROM [dbo].[gccontacts]
	WHERE hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deletecourses]
	
@p_hid INTEGER
/*@p_coursetype VARCHAR(2)*/

AS

	SET NOCOUNT ON

	DELETE FROM [dbo].[gccourses]
	WHERE hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_deleteprereqs]
	
@p_hid INTEGER


AS

	SET NOCOUNT ON

	DELETE FROM [dbo].[gcprequisites]
	WHERE hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_getdata]

@p_certid INTEGER = NULL,
@p_coursetype VARCHAR(2) = NULL

AS
	

		select hid, certificatecode, certificatename, collegecode, linkname, certificatetitle, courselocation,
		briefdesc, CEU, credittograd, transfercredit, standardtests, prerequisiteinfo, admissionreq, appprocess, registrationprocess,
		tuitionfees, financialaid, timelimit, deptwebsite, requiredcourseinfo, electivecourseinfo, certtype, status
		from [dbo].[gccertificatedetails]
		where hid = @p_certid

		select hid, hcertificatedetails, prerequisites
		from [dbo].[gcprequisites]
		where hcertificatedetails = @p_certid

		select hid, hcertificatedetails, admissionreqdocuments
		from [dbo].[gcadmissionrequirements]
		where hcertificatedetails = @p_certid

		select hid, hcertificatedetails, applicationrequirements
		from [dbo].[gcapplicationrequirements]
		where hcertificatedetails = @p_certid

		select hid, hcertificatedetails, fname, lname, phone, email, picturelink
		from [dbo].[gccontacts]
		where hcertificatedetails = @p_certid

		select hid, hcertificatedetails, coursetype, coursename
		from [dbo].[gccourses]
		where hcertificatedetails = @p_certid and coursetype = @p_coursetype

		SELECT hid, certificatename, certtype, status
		FROM [dbo].[gccertificatedetails]

		SELECT hid, certificatename, certtype, status
		FROM [dbo].[gccertificatedetails]
		WHERE hid = @p_certid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_insertadmissionreq]


@p_certid INTEGER,
@p_admissionreqdocuments VARCHAR(250)
/*@p_iorder INTEGER*/

AS

	SET NOCOUNT ON


	INSERT INTO  [dbo].[gcadmissionrequirements]
	(hcertificatedetails,admissionreqdocuments)
	values( @p_certid, @p_admissionreqdocuments)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_insertapplicationreq]
	
@p_certid INTEGER,
@p_applicationreqdocuments VARCHAR(250)


AS

	SET NOCOUNT ON


	INSERT INTO  [dbo].[gcapplicationrequirements]
	(hcertificatedetails,applicationrequirements)
	values(@p_certid, @p_applicationreqdocuments)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_insertcontacts]

@p_certid INTEGER,
@p_fname VARCHAR(20),
@p_lname VARCHAR(50),
@p_phone VARCHAR(50),
@p_email VARCHAR(50),
@p_picturelink VARCHAR(500),
@p_pict_type VARCHAR(225)

AS

	SET NOCOUNT ON


	INSERT INTO  [dbo].[gccontacts]
	(hcertificatedetails,fname,lname, phone,email, picturelink,pict_type)
	values( @p_certid, @p_fname,@p_lname,@p_phone,@p_email, @p_picturelink, @p_pict_type)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_insertcourses]

@p_certid INTEGER,
@p_coursetype VARCHAR(2),
@p_coursename VARCHAR(500)

AS

	SET NOCOUNT ON


	INSERT INTO  [dbo].[gccourses]
	(hcertificatedetails,coursetype,coursename)
	values( @p_certid, @p_coursetype,@p_coursename)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_insertprereqs]


@p_certid INTEGER,
@p_prerequisites VARCHAR(500)


AS

	SET NOCOUNT ON


	INSERT INTO  [dbo].[gcprequisites]
	(hcertificatedetails,prerequisites)
	values( @p_certid, @p_prerequisites)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_inserttitledetails]
	
@p_certcode VARCHAR(4),
@p_certname VARCHAR(225),
@p_collegecode VARCHAR(10),
@p_linkname VARCHAR(225),
@p_certtitle VARCHAR(225),
@p_courselocation VARCHAR(1000),
@p_briefdesc VARCHAR(5000),
@p_CEU VARCHAR(1500),
@p_credittograd VARCHAR(1500),
@p_transfercredit VARCHAR(1500),
@p_standardtests VARCHAR(5000),
@p_prereq VARCHAR(1500),
@p_admissionreq VARCHAR(1500),
@p_appprocess VARCHAR(1500),
@p_registrationprocess VARCHAR(1500),
@p_tutionfees VARCHAR(1000),
@p_financialaid VARCHAR(500),
@p_timelimit VARCHAR(500),
@p_deptwebsite VARCHAR(200),
@p_requiredcourseinfo VARCHAR(500),
@p_electivecourseinfo VARCHAR(500),
@p_certtype VARCHAR(3),
@p_hid INTEGER OUTPUT

AS

	SET NOCOUNT ON


	INSERT INTO [dbo].[gccertificatedetails]
	(certificatecode, certificatename, collegecode, linkname, certificatetitle, courselocation, briefdesc, CEU,
 	credittograd,transfercredit, standardtests, prerequisiteinfo, admissionreq, appprocess, registrationprocess, tuitionfees,
	financialaid, timelimit, deptwebsite, requiredcourseinfo, electivecourseinfo, certtype,
	status)
	VALUES (@p_certcode, @p_certname, @p_collegecode, @p_linkname, @p_certtitle, @p_courselocation, @p_briefdesc, @p_CEU,
	 @p_credittograd, @p_transfercredit, @p_standardtests, @p_prereq, @p_admissionreq, @p_appprocess, @p_registrationprocess, @p_tutionfees, @p_financialaid, @p_timelimit,
	@p_deptwebsite, @p_requiredcourseinfo, @p_electivecourseinfo, @p_certtype,0)

	SET @p_hid = SCOPE_IDENTITY()

	SELECT @@Identity  AS hid;
	
	INSERT INTO  [dbo].[gcstatus]
	(hcertificatedetails,titlestatus,adreqstatus,appreqstatus,contactstatus,reqcoursestatus,electivestatus)
	values(@@Identity,1,0,0,0,0,0)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updatecertstatus]

@p_certid INTEGER,
@p_status INTEGER

AS
BEGIN
update [dbo].[gccertificatedetails]
set status = @p_status where hid = @p_certid
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updateinsertadmissionreq]

@p_hid INTEGER,
@p_certid INTEGER,
@p_admissionreqdocuments VARCHAR(250)


AS

	SET NOCOUNT ON


	/*INSERT INTO  [dbo].[gcadmissionrequirements]
	(hcertificatedetails,admissionreqdocuments)
	values(@p_certid, @p_admissionreqdocuments)*/

	UPDATE   [dbo].[gcadmissionrequirements]
	SET admissionreqdocuments = @p_admissionreqdocuments
	WHERE hcertificatedetails = @p_certid AND hid = @p_hid


	/*SELECT @@Identity  AS hid;
	
	UPDATE  [dbo].[gcstatus]
	SET adreqstatus = 1 WHERE
	hcertificatedetails = @p_certid*/
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updateinsertapplicationreq]

@p_hid INTEGER,
@p_certid INTEGER,
@p_applicationrequirements VARCHAR(250)


AS

	SET NOCOUNT ON


	

	UPDATE   [dbo].[gcapplicationrequirements]
	SET applicationrequirements = @p_applicationrequirements
	WHERE hcertificatedetails = @p_certid AND hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updateinsertcontacts]

@p_hid INTEGER,
@p_certid INTEGER,
@p_fname VARCHAR(20),
@p_lname VARCHAR(50),
@p_phone VARCHAR(50),
@p_email VARCHAR(50)
/*@p_picturelink IMAGE*/

AS

	SET NOCOUNT ON


	UPDATE   [dbo].[gccontacts]
	SET fname = @p_fname , lname = @p_lname , phone = @p_phone , email = @p_email 
	WHERE hcertificatedetails = @p_certid AND hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updateinsertcourses]

@p_hid INTEGER,
@p_certid INTEGER,
@p_coursetype VARCHAR(2),
@p_coursename VARCHAR(500)


AS

	SET NOCOUNT ON


	

	UPDATE   [dbo].[gccourses]
	SET coursetype = @p_coursetype , coursename = @p_coursename
	WHERE hcertificatedetails = @p_certid AND hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updateinsertprereqs]

@p_hid INTEGER,
@p_certid INTEGER,
@p_prerequisites VARCHAR(250)


AS

	SET NOCOUNT ON


	

	UPDATE [dbo].[gcprequisites]
	SET prerequisites = @p_prerequisites
	WHERE hcertificatedetails = @p_certid AND hid = @p_hid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE [dbo].[metro_gc_updatestatus]

@p_certid INTEGER,
@ColumnName varchar(100)

AS



IF @ColumnName = 'TABPANEL2' 
	
		UPDATE [dbo].[gcstatus]
		SET adreqstatus = 1
		WHERE hcertificatedetails = @p_certid

ELSE IF @ColumnName = 'TABPANEL3'
		
		UPDATE [dbo].[gcstatus]
		SET appreqstatus = 1
		WHERE hcertificatedetails = @p_certid

ELSE IF @ColumnName = 'TABPANEL4'
		
		UPDATE [dbo].[gcstatus]
		SET contactstatus = 1
		WHERE hcertificatedetails = @p_certid

ELSE IF @ColumnName = 'TABPANEL5'
		
		UPDATE [dbo].[gcstatus]
		SET reqcoursestatus = 1
		WHERE hcertificatedetails = @p_certid

ELSE IF @ColumnName = 'TABPANEL6'
		
		UPDATE [dbo].[gcstatus]
		SET electivestatus = 1
		WHERE hcertificatedetails = @p_certid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_gc_updatetitledetails]

@p_certid INTEGER,
@p_certcode VARCHAR(4),
@p_certname VARCHAR(225),
@p_collegecode VARCHAR(10),
@p_linkname VARCHAR(225),
@p_certtitle VARCHAR(225),
@p_courselocation VARCHAR(1000),
@p_briefdesc VARCHAR(5000),
@p_CEU VARCHAR(1500),
@p_credittograd VARCHAR(1500),
@p_transfercredit VARCHAR(1500),
@p_standardtests VARCHAR(5000),
@p_prereq VARCHAR(1500),
@p_admissionreq VARCHAR(1500),
@p_appprocess VARCHAR(1500),
@p_registrationprocess VARCHAR(1500),
@p_tutionfees VARCHAR(1000),
@p_financialaid VARCHAR(500),
@p_timelimit VARCHAR(500),
@p_deptwebsite VARCHAR(200),
@p_requiredcourseinfo VARCHAR(500),
@p_electivecourseinfo VARCHAR(500),
@p_certtype VARCHAR(3)


AS

	SET NOCOUNT ON


	UPDATE [dbo].[gccertificatedetails]
 	SET certificatecode = @p_certcode ,
	certificatename =  @p_certname ,
	collegecode = @p_collegecode ,
	linkname = @p_linkname ,
	certificatetitle = @p_certtitle ,
	courselocation = @p_courselocation ,
	briefdesc = @p_briefdesc , 
	CEU = @p_CEU ,
	credittograd = @p_credittograd,
	transfercredit = @p_transfercredit ,
	standardtests = @p_standardtests ,
	prerequisiteinfo = @p_prereq,
	admissionreq = @p_admissionreq ,
	appprocess = @p_appprocess ,
	registrationprocess = @p_registrationprocess ,
	tuitionfees = @p_tutionfees ,
	financialaid = @p_financialaid ,
	timelimit =  @p_timelimit ,
	deptwebsite = @p_deptwebsite , 
	requiredcourseinfo = @p_requiredcourseinfo ,
	electivecourseinfo =  @p_electivecourseinfo ,
	certtype = @p_certtype
	WHERE hid = @p_certid
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE [dbo].[metro_get_certinfo]
@p_certcode varchar(4)

AS

declare @v_certiid int

select @v_certiid = hid from [dbo].[gccertificatedetails]
where [dbo].[gccertificatedetails].certificatecode = @p_certcode

 
-- Get certificate details         
select certificatename, collegecode, linkname, certificatetitle, courselocation,
briefdesc, CEU, credittograd, transfercredit, standardtests, prerequisiteinfo, admissionreq, appprocess, registrationprocess,
tuitionfees, financialaid, timelimit, deptwebsite, requiredcourseinfo, electivecourseinfo, certtype, status
from [dbo].[gccertificatedetails]
where hid = @v_certiid

-- Get pre-requisites
select prerequisites from [dbo].[gcprequisites]
where hcertificatedetails = @v_certiid

-- Get admission requirements
select admissionreqdocuments from [dbo].[gcadmissionrequirements]
where hcertificatedetails = @v_certiid

-- Get Application Requirements
select applicationrequirements from [dbo].[gcapplicationrequirements]
where hcertificatedetails = @v_certiid

-- Get Contacts
select fname, lname, phone, email, picturelink from [dbo].[gccontacts]
where hcertificatedetails = @v_certiid

-- Get Required course list
select coursename from [dbo].[gccourses]
where hcertificatedetails = @v_certiid and coursetype = 'RQ'

-- Get Elective course list
select coursename from [dbo].[gccourses]
where hcertificatedetails = @v_certiid and coursetype = 'EL'


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE [dbo].[metro_logincheck] 
(

		@p_urid INTEGER OUTPUT,
		@p_urnetid VARCHAR(20),
		@p_urfname VARCHAR(20) OUTPUT,
		@p_urlname VARCHAR(50) OUTPUT,
		@p_urrole INTEGER OUTPUT
		
	)
AS
	/*SET NOCOUNT ON  */
	
	SELECT @p_urid  = [hid], @p_urnetid = [urnetid], @p_urfname = [ur_fname],
		 @p_urlname =  [ur_lname], @p_urrole = [ur_role]
	FROM  [dbo].[gcusers] 
    	WHERE [urnetid] = @p_urnetid
	
	RETURN
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

