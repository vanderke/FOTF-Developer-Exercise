class LessonsController < ApplicationController
  before_action :require_signin, except: [:index, :show]
  before_action :require_admin, except: [:index, :show]

  def index
    @lessons = Lesson.all
  end

  def new
    @lesson = Lesson.new
  end

  def create
    @lesson = Lesson.new(lesson_params)
    if @lesson.save
      redirect_to @lesson, notice: "Lesson successfully created!"
    else
      render :new
    end
  end

  def show
    @lesson = Lesson.find(params[:id])
  end

  def edit
    @lesson = Lesson.find(params[:id])
  end

  def update
    @lesson = Lesson.find(params[:id])
    if @lesson.update(lesson_params)
      redirect_to @lesson, notice: "Lesson successfully updated!"
    else
      render :edit
    end
  end

  def destroy
    @lesson = Lesson.find(params[:id])
    @lesson.destroy
    redirect_to lessons_url, alert: "Lesson successfully deleted!"
  end

private

  def require_admin
    unless current_user_admin?
      redirect_to root_url, alert: "Unauthorized access."
    end
  end

  def lesson_params
    params.require(:lesson).permit(:chapter, :title, :summary)
  end
end
