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
CREATE PROCEDURE Medecin_Update
	-- Add the parameters for the stored procedure here
	@p_id INT,
    @p_nom VARCHAR(50),
    @p_prenom VARCHAR(50),
    @p_adresse VARCHAR(100),
    @p_tel VARCHAR(20),
    @p_specialiteComplementaire VARCHAR(100),
    @p_departement VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 UPDATE dbo.medecin 
    SET nom = @p_nom, 
        prenom = @p_prenom,
        adresse = @p_adresse,
        tel = @p_tel,
        specialiteComplementaire = @p_specialiteComplementaire,
        departement = @p_departement
    WHERE id = @p_id;
END
GO
