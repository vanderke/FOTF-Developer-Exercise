def user_attributes(overrides = {})
  {
    email: "user@example.com",
    password: "super-secret",
    password_confirmation: "super-secret",
    username: "movielover"
  }.merge(overrides)
end

def lesson_attributes(overrides = {})
  {
    chapter: "1",
    title: "Two Roads Diverged in A Yellow Wood",
    summary: "Stick to what you are called to do."
  }.merge(overrides)
end
