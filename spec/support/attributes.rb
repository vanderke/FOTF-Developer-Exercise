def user_attributes(overrides = {})
  {
    email: "user@example.com",
    password: "super-secret",
    password_confirmation: "super-secret",
    username: "movielover"
  }.merge(overrides)
end
