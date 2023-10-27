import os
import shutil

BASE_DIR = os.path.dirname(os.path.abspath(__file__))

if __name__ == "__main__":
    to_remove = []
    for root, dirs, files in os.walk(BASE_DIR):
        for dir_name in dirs:
            if dir_name in ['obj', 'bin']:
                path = os.path.join(root, dir_name)
                to_remove.append(path)
    for path in to_remove:
        print(path)
        shutil.rmtree(path)