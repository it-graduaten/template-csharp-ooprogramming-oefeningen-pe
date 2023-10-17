import os
import shutil
import json

# Read the chapters from the chapters.json file
with open('chapters.json') as f:
    chapters = json.load(f)
f.close()

for chapter in enumerate(chapters):
    # Get the chapter name
    chapter_name = chapter[1]['name']
    # Get the chapter number, with leading zero if needed
    chapter_number = str(chapter[0] + 1).zfill(2)
    # Create a folder for the chapter if it doesn't exist
    if not os.path.exists(chapter_number):
        os.mkdir(chapter_number)
    # Add a README.md file to each chapter
    with open(chapter_number + '/README.md', 'w') as f:
        f.write('# ' + chapter_name)
    f.close()

    for i in range(0, 5):
        # Exercise number with leading zero
        exercise_number = str(i).zfill(2)
        # Copy the template folder, called 00_00, to the chapter folder
        shutil.copytree('00_00', chapter_number + '/00_00')
        # Rename the folder to the correct exercise number
        os.rename(chapter_number + '/00_00', chapter_number + '/' +
                  chapter_number + '_' + exercise_number)
        # Rename the solution file, called '00_00.sln' to the correct exercise number
        os.rename(chapter_number + '/' + chapter_number + '_' + exercise_number + '/00_00.sln', chapter_number + '/' +
                  chapter_number + '_' + exercise_number + '/' + chapter_number + '_' + exercise_number + '.sln')
        # Add a README.md file to each exercise
        with open(chapter_number + '/' + chapter_number + '_' + exercise_number + '/README.md', 'w') as f:
            f.write('# ' + chapter_number + '_' + exercise_number)
        f.close()
