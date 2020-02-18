CREATE PROCEDURE [dbo].[spUserInfor]
@Id nvarchar(128)
AS
begin
--stored procedure for getting user information
	set nocount on;


    SELECT 
        Profile.Id,
        Profile.Name,
        Profile.Surname,
        Profile.IDNumber,
        Profile.Gender,
        Profile.Address,
        Profile.AccessId
    FROM Profile
    INNER JOIN Users ON Profile.Id = Users.ProfileId
    Where Users.Id = @Id
end