require 'rails_helper'

describe ReviewsController do

  before do
    @lesson = Lesson.create!(lesson_attributes)
  end

  context "when not signed in" do

    before do
      session[:user_id] = nil
    end

    it "cannot access review new" do
      get :new, lesson_id: @lesson

      expect(response).to redirect_to(new_session_url)
    end

    it "cannot access review create" do
      post :create, lesson_id: @lesson

      expect(response).to redirect_to(new_session_url)
    end
  end
end
