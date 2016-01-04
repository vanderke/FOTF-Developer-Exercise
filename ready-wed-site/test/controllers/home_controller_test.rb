require 'test_helper'

class HomeControllerTest < ActionController::TestCase
	
	#TESTS FOR INDEX PAGE
	test "home controller should get index" do
    	get :index
    	assert_response :success, "The response was unsuccessful."
	end

	test "home controller should render the index view" do
		get :index
		assert_template :index, "The index view was not displayed."
		assert_template layout: "layouts/application"
	end

	test "home controller should assign @chapters object to the index view" do
  		get :index
  		assert_not_nil assigns(:chapters), "The @chapters object did not make it to response."
    	assert_not_empty assigns(:chapters), "The @chapters object is empty and it shouldn't be."
	end

	#TESTS FOR MEET PAGE
	test "home should get meet" do
    	get :meet
    	assert_response :success, "The response was unsuccessful."
	end

	test "home controller should render the meet view" do
		get :meet
		assert_template :meet, "The meet view was not displayed"
		assert_template layout: "layouts/application"
	end

	test "home controller should assign @author object to the meet view" do
		get :meet
		assert_not_nil assigns(:author), "The @author object did not make it to the response."
	end
end
