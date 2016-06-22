json.user do
  json.id @user.id
  json.username @user.username
  json.email @user.email
  json.admin @user.admin
  json.created_at @user.created_at
  json.updated_at @user.updated_at
  json.password @user.password
  json.password_confirmation @user.password_confirmation
end
