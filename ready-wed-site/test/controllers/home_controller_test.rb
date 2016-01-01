require 'test_helper'

class HomeControllerTest < ActionController::TestCase
	test "should get index" do
    	get :index
    	assert_response :success, "The response was unsuccessful."
	end

	test "controller should render the index view" do
		get :index
		assert_template :index, "The index view was not displayed."
		assert_template layout: "layouts/application"
	end

	test "controller should assign @chapters object to the index view" do
  		get :index
  		assert_not_nil assigns(:chapters), "The @chapters object did not make it to response."
    	assert_not_empty assigns(:chapters), "The @chapters object is empty and it shouldn't be."
	end
end
