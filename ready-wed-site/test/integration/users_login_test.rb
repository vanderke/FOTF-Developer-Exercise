require 'test_helper'

class UsersLoginTest < ActionDispatch::IntegrationTest
  test "login with invalid information" do
  	get root_path
  	assert_template :index
  	post login_path, session: {email: "", password: ""}
  	assert_not flash.empty?
  	get root_path
  	assert_nil flash[:danger], "I do not know why this is failing. Flash[:danger] should not have anything, but the app works as desired, so leave this for now"
  end
end
