class UsersController < ApplicationController
  def show
  	flash[:userid] = params[:id]
  	redirect_to "/"
  end

  def new
  	@user = User.new
  end

  def create
  	@user = User.new(user_params)
  	if @user.save
  		flash[:userid] = @user.id
  		redirect_to "/"
  	else
  		render "new"
  	end
  end

  def signout
  	@user = nil
  	render "/"
  end

  private
  	def user_params
  		params.require(:user).permit(:name, :email, :password, :password_confirmation)
  	end
end
