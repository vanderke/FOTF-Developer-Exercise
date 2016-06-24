require 'rails_helper'

describe "Deleting a lesson" do
  before do
    admin = User.create!(user_attributes(admin: true))
    sign_in(admin)
  end

  it "destroys the lesson and shows the lesson listing without the deleted lesson" do
    lesson = Lesson.create!(lesson_attributes)

    visit lesson_path(lesson)

    click_link 'Delete'

    expect(current_path).to eq(lessons_path)
    expect(page).not_to have_text(lesson.title)
    expect(page).to have_text("Lesson successfully deleted!")
  end
end
