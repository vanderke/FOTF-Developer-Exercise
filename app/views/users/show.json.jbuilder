json.user do
  json.id @user.id
  json.username @user.username
  json.admin @user.admin
  json.password @user.password
  json.password_confirmation @user.password_confirmation
  json.created_at @user.created_at
  json.updated_at @user.updated_at
end
