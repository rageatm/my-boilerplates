module.exports = {
  env: { browser: true, node: true },
  extends: [
    'next/core-web-vitals',
    'eslint:recommended',
    'plugin:prettier/recommended',
    'plugin:react/recommended',
    'plugin:@typescript-eslint/recommended',
  ],
  rules: { 'react/react-in-jsx-scope': 'off' },
};
