-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Medecin_Add
	-- Add the parameters for the stored procedure here
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
	INSERT INTO dbo.medecin (nom, prenom, adresse, tel, specialiteComplementaire, departement) 
	VALUES (@p_nom, @p_prenom, @p_adresse, @p_tel, @p_specialiteComplementaire, @p_departement);
END
GO
