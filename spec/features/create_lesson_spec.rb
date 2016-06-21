require 'rails_helper'

describe "Creatine a new lesson as an admin" do
  before do
    admin = User.create!(user_attributes(admin:true))
    sign_in(admin)
  end

  it "saves the lesson and shows the new lesson's details" do
    visit lessons_url

    click_link 'Add New Lesson'

    expect(current_path).to eq(new_lesson_path)

    fill_in "Chapter", with: "13"
    fill_in "Title", with: "Getting your spouse to heaven."
    fill_in "Summary", with: "This chapter answers the question, why marry?"

    click_button 'Create Lesson'

    expect(current_path).to eq(lesson_path(Lesson.last))

    expect(page).to have_text('Getting your spouse to heaven.')
    expect(page).to have_text('Lesson successfully created!')
  end

  it "does not save the lesson if it's invalid" do
    visit new_lesson_path

    expect {
      click_button 'Create Lesson'
    }.not_to change(Lesson, :count)

    expect(page).to have_text('error')
  end
end
