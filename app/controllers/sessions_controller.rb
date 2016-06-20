class SessionsController < ApplicationController
  def new
  end

  def create
    if user = User.authenticate(params[:username], params[:password])
      session[:user_id] = user.id
      flash[:notice] = "Welcome back, #{user.username}!"
      redirect_to user
    else
      flash.now[:alert] = "Invalid username or password."
      render :new
    end
  end
end
