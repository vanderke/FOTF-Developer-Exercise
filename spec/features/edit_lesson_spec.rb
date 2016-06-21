require 'rails_helper'

describe "Editing a lesson" do
  before do
    admin = User.create!(user_attributes(admin:true))
    sing_in(admin)
  end

  it "updates the lesson and shows the lesson's updated details" do
    lesson = Lesson.create!(lesson_attributes)

    visit lesson_url(lesson)

    click_link 'Edit Lesson'

    expect(current_path).to eq(edit_lesson_path(lesson))

    expect(find_field('Chapter').value).to eq(lesson.chapter)

    fill_in "Chapter", with: "14"

    click_button "Update Lesson"

    expect(current_path).to eq(lesson_path(lesson.reload))

    expect(page).to have_text('14')
    expect(page).to have_text('Lesson successfully updated!')
  end

  it "does not update the lesson if it's invalid" do
    lesson = Lesson.create!(lesson_attributes)

    visit edit_lesson_path(lesson)

    fill_in 'Chapter', with: " "

    click_button "Update Lesson"

    expect(page).to have_text('error')
  end
end
