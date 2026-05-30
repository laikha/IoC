const fs = require("fs");
const path = require("path");

function pad(num, size) {
  return String(num).padStart(size, "0");
}

function readJson(filePath) {
  const raw = fs.readFileSync(filePath, "utf8");
  return JSON.parse(raw);
}

function writeJson(filePath, data) {
  fs.writeFileSync(filePath, JSON.stringify(data, null, 2) + "\n", "utf8");
}

function assertValid(v) {
  const fields = ["major", "minor", "build"];
  for (const f of fields) {
    if (typeof v[f] !== "number" || !Number.isInteger(v[f]) || v[f] < 0) {
      throw new Error(`VERSION.json inválido: campo '${f}' deve ser inteiro >= 0.`);
    }
  }
}

function bump(v) {
  // Regras:
  // build++ ; se build > 99 => build=0, minor++ ; se minor > 999 => minor=0, major++
  v.build += 1;

  if (v.build > 99) {
    v.build = 0;
    v.minor += 1;
  }

  if (v.minor > 999) {
    v.minor = 0;
    v.major += 1;
  }

  return v;
}

function formatVersion(v) {
  // major sem padding; minor 3 dígitos; build 2 dígitos
  return `${v.major}.${pad(v.minor, 3)}.${pad(v.build, 2)}`;
}

function setOutput(key, value) {
  const out = process.env.GITHUB_OUTPUT;
  if (!out) return;
  fs.appendFileSync(out, `${key}=${value}\n`, "utf8");
}

(function main() {
  const filePath = path.join(process.cwd(), "VERSION.json");

  if (!fs.existsSync(filePath)) {
    throw new Error("VERSION.json não encontrado na raiz do repositório.");
  }

  const version = readJson(filePath);
  assertValid(version);

  const next = bump(version);
  writeJson(filePath, next);

  const versionStr = formatVersion(next);

  console.log(`Version bumped to: ${versionStr}`);

  setOutput("version", versionStr);
  setOutput("major", String(next.major));
  setOutput("minor", String(next.minor));
  setOutput("build", String(next.build));
})();