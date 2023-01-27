import os
import shutil

chapters = [
    { 'number': '01', 'name': 'Sequentie', 'file': 'sequence' },
    { 'number': '02', 'name': 'Selectie deel 1', 'file': 'selection-part-1' },
    { 'number': '03', 'name': 'Selectie deel 2', 'file': 'selection-part-2' },
    { 'number': '04', 'name': 'For loop', 'file': 'for-loop' },
    { 'number': '05', 'name': 'Do while', 'file': 'do-while' },
    { 'number': '06', 'name': 'While do', 'file': 'while-do' },
    { 'number': '07', 'name': 'Collecties', 'file': 'collections' },
    { 'number': '08', 'name': 'Methodes', 'file': 'methods' },
    { 'number': '09', 'name': 'Stringmethodes', 'file': 'stringmethods' },
    { 'number': '10', 'name': 'Bestanden', 'file': 'files' },
]

# For each chapter create a folder
for chapter in chapters:
    chapter_number = chapter['number']
    chapter_name = chapter['name']
    chapter_file = chapter['file']
    print('Creating folder for chapter ' + chapter_number + ' - ' + chapter_name)
    os.mkdir(chapter_number)
    # Create a subfolder for each 5 exercises
    for i in range(0, 6):
        exercise_number = str(i).zfill(2)
        print('Creating folder for exercise ' + chapter_number + '_' + exercise_number)
        os.mkdir(chapter_number + '/' + chapter_number + '_' + exercise_number)
        # Create a README.md file with the name of exercise as title
        with open(chapter_number +  '/' + chapter_number + '_' + exercise_number + '/README.md', 'w') as f:
            f.write('# ' + chapter_number + '_' + exercise_number + '\n')
        # Copy the .gitignore file to the folder
        shutil.copyfile('.gitignore', chapter_number +  '/' + chapter_number + '_' + exercise_number + '/.gitignore')
        # Scaffold a solution with a 'console' and a 'models' project in the folder
        commands = ["dotnet new sln", "dotnet new console -f netcoreapp3.1 -o console",
                    "dotnet new classlib -f netcoreapp3.1 -o models", "dotnet sln add console", "dotnet sln add models"]
        for command in commands:
            os.system('cd ' + chapter_number + '/' + chapter_number + '_' + exercise_number + ' && ' + command)
        # Remove the 'Class1.cs' from the models project
        os.remove(chapter_number + '/' + chapter_number + '_' + exercise_number + '/models/Class1.cs')

