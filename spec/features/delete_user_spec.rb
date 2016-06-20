require 'rails_helper'

describe "Delete a user" do
  it "destroys the user and redirects to the home page" do
    user = User.create!(user_attributes)

    sign_in(user)

    visit user_path(user)

    click_link 'Delete Account'

    expect(current_path).to eq(root_path)
    expect(page).to have_text('Account successfully deleted!')

    visit root_path

    expect(page).not_to have_text(user.username)
  end
end
