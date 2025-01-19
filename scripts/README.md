# Scripts

requirements:

- python 3.13
- [uv](https://docs.astral.sh/uv/)

## merge-line-openapi.py

Read `../line-openapi/` directory and merge all yaml files (exclude dot file yamls)

```bash
uv run merge-line-openapi.py
```

Output file: `../merged-line-openapi.yaml`
