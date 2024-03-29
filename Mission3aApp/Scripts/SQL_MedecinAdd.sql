USE [gsbrapports2016]
GO
/****** Object:  StoredProcedure [dbo].[Medecin_Add]    Script Date: 21/03/2024 14:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Medecin_Add]
	-- Add the parameters for the stored procedure here
	@p_id INT,
	@p_nom VARCHAR(100),
	@p_prenom VARCHAR(100),
	@p_adresse VARCHAR(100),
	@p_tel INT,
	@p_specialiteComplementaire VARCHAR(100),
	@p_departement INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.medecin (id, nom, prenom, adresse, tel, specialiteComplementaire, departement) 
	VALUES (@p_id, @p_nom, @p_prenom, @p_adresse, @p_tel, @p_specialiteComplementaire, @p_departement);
END
