class CreateAuthors < ActiveRecord::Migration
  def change
    drop_table :authors if ActiveRecord::Base.connection.table_exists? :authors
    create_table :authors, id: false do |t|
      t.primary_key :id
      t.text :name, null: false
      t.text :about, null: false

      t.timestamps null: false
    end
  end
end
