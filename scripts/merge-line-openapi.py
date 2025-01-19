import yaml
import os
from collections import defaultdict
from pathlib import Path

def merge_openapi_files(file_paths, output_path):
    merged_openapi = {
        "openapi": "3.0.0",
        "info": {
            "title": "Merged API",
            "version": "1.0.0",
            "description": "Merged OpenAPI specification"
        },
        "paths": {},
        "components": {
            "schemas": {},
            "responses": {},
            "parameters": {},
            "securitySchemes": {},
        },
    }

    for file_path in file_paths:
        with open(file_path, 'r') as file:
            openapi = yaml.safe_load(file)

            # Merge paths
            for path, methods in openapi.get("paths", {}).items():
                if path not in merged_openapi["paths"]:
                    merged_openapi["paths"][path] = methods
                else:
                    for method, details in methods.items():
                        merged_openapi["paths"][path][method] = details

            # Merge components
            for component_type, items in openapi.get("components", {}).items():
                if component_type in merged_openapi["components"]:
                    for name, definition in items.items():
                        if name not in merged_openapi["components"][component_type]:
                            merged_openapi["components"][component_type][name] = definition
                        else:
                            print(f"Duplicate {component_type[:-1]} found: {name}. Skipping.")

    # Write merged OpenAPI to output file
    with open(output_path, 'w') as output_file:
        yaml.dump(merged_openapi, output_file, sort_keys=False)

    print(f"Merged OpenAPI file saved to {output_path}")

# Get all YAML files from ../line-openapi directory
def get_yaml_files(directory):
    yaml_files = []
    for file in Path(directory).glob('*.[yY][mM][lL]'):
        # Skip files that start with a dot
        if not file.name.startswith('.'):
            yaml_files.append(str(file))
    return yaml_files

# Get the directory path relative to the script location
script_dir = Path(__file__).parent
openapi_dir = script_dir.parent / 'line-openapi'
output_file = script_dir.parent / 'merged-line-openapi.yaml'

# Get all YAML files and merge them
openapi_files = get_yaml_files(openapi_dir)
if not openapi_files:
    print(f"No YAML files found in {openapi_dir}")
else:
    print(f"Found {len(openapi_files)} YAML files to merge:")
    for file in openapi_files:
        print(f"  - {file}")
    merge_openapi_files(openapi_files, output_file)
