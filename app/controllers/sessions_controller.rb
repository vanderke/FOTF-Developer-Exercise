class SessionsController < ApplicationController
  respond_to :html, :json

  def new
  end

  def create
    respond_to do |format|
      if user = User.authenticate(params[:username], params[:password])
        session[:user_id] = user.id
        flash[:notice] = "Welcome back, #{user.username}!"
        format.html { redirect_to(session[:intended_url] || root_url) }
        session[:intended_url] = nil
        format.json { render json: @user, status: :created, localation: @user }
      else
        flash.now[:alert] = "Invalid username or password."
        format.html { render :new }
        format.json { render json: @user.errors, status: :unprocessable_entity }
      end
    end
  end

  def destroy
    session[:user_id] = nil
    redirect_to root_url, notice: "Successfully signed out!"
  end
end
